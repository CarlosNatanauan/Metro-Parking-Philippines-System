using Metro_Parking_System.AdmData;
using Metro_Parking_System.EmpData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Metro_Parking_System.mainFormAdmin;

namespace Metro_Parking_System1
{
    internal class databaseCodes
    {

        /* About sa connection string to(para magamit sa multiple computer on the same NET)
           - IP Address mo plus lagi mo i add sa Firewall yung 1433 na port
           - Tapos wag mo kalimutan enable TCP/IP sa Config Manager, lastly refresh yung DB to take effect.
        */
        private static string connectionString = "Data Source=192.168.0.104,1433;Initial Catalog=Metro_Parking;User ID=kuyacarlos;Password=kuyacarlos;";


        internal static void UpdateConnectionString(string ipAddress)
        {
            connectionString = $"Data Source={ipAddress},1433;Initial Catalog=Metro_Parking;User ID=kuyacarlos;Password=kuyacarlos;";
        }
        internal static bool IsBackupOrRestoreInProgress = false;



        //--------------------------- FOR FLATRATE SECTION ---------------------------//
        public static bool InsertPlateNumberFlatrate(string plateNumber, string name, string vehicleType, DateTime timeIn)
        {
            string selectedPlace = ChooseRandomPlaceFlatrate();
            if (string.IsNullOrEmpty(selectedPlace))
            {
                // No suitable place found
                return false;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Fetch the current value of the selected place
                SqlCommand fetchPlaceValueCommand = new SqlCommand($"SELECT {selectedPlace} FROM parking_place", connection);
                int currentValue = (int)fetchPlaceValueCommand.ExecuteScalar();

                if (currentValue <= 0) // Check if there are no available spots
                {
                    // Since the current place is full, call the function recursively to find another place
                    return InsertPlateNumberFlatrate(plateNumber, name, vehicleType, timeIn);
                }

                // Insert into Flatrate_raw table
                SqlCommand command = new SqlCommand("INSERT INTO Flatrate_raw(plateNumber, name, vehicleType, TimeIn, place) VALUES (@PlateNumber, @Name, @VehicleType, @TimeIn, @Place)", connection);
                command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@VehicleType", vehicleType);
                command.Parameters.AddWithValue("@TimeIn", timeIn);
                command.Parameters.AddWithValue("@Place", selectedPlace);
                command.ExecuteNonQuery();

                // Update the parking_place table to decrement the current capacity for the selected place
                SqlCommand updatePlaceCommand = new SqlCommand($"UPDATE parking_place SET {selectedPlace} = @NewValue", connection);
                updatePlaceCommand.Parameters.AddWithValue("@NewValue", currentValue - 1); // Decrementing as per the requirement
                updatePlaceCommand.ExecuteNonQuery();
            }

            return true;
        }


        public static string ChooseRandomPlaceFlatrate()
        {
            List<string> places = new List<string> { "MT1", "MT2", "MT3" };
            Random random = new Random();
            places = places.OrderBy(x => random.Next()).ToList(); // Shuffle the places list

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT mt1, mt2, mt3 FROM parking_place", connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // Iterate through the shuffled places
                    foreach (string place in places)
                    {
                        // Check the available space for the randomly selected place
                        if (reader.GetInt32(places.IndexOf(place)) > 0)
                        {
                            return place; // Return the random place that has space available
                        }
                    }
                }
            }

            return null; // No suitable place found
        }//choose random place

        public static DataTable GetAllPlateNumbersFlatrate()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Include the "place" column in the SELECT statement
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, plateNumber, name, vehicleType, CONVERT(varchar, TimeIn, 108) AS TimeIn, TimeOut, Rate, place FROM Flatrate_raw", connection);
                adapter.Fill(dt);

                // Modify the format of the TimeIn column to display only hours, minutes, and seconds
                foreach (DataRow row in dt.Rows)
                {
                    if (row["TimeIn"] != DBNull.Value)
                    {
                        row["TimeIn"] = DateTime.Parse(row["TimeIn"].ToString()).ToString("MMMM dd HH:mm:ss");
                    }
                }
            }
            return dt;
        }//Retrieves all flatrate parking records.





        //update on out
        public static DataRow GetFlatrateRecordById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Flatrate_raw WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                return null;
            }
        }

        public static DataRow GetFlatrateRecordByIdLog(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Flatrate_log WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                return null;
            }
        }


        public static void UpdatePlateNumberFlatrate(string oldPlateNumber, string newPlateNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UPDATE Flatrate_raw SET plateNumber = @newPlateNumber WHERE plateNumber = @oldPlateNumber", connection))
                {
                    command.Parameters.AddWithValue("@newPlateNumber", newPlateNumber);
                    command.Parameters.AddWithValue("@oldPlateNumber", oldPlateNumber);

                    command.ExecuteNonQuery();
                }
            }
        }//Updates the plate number of a flatrate parking record.

        // New method to retrieve rates and penalties from the database
        public static (decimal RateFlatEntry, decimal OthersPenLossTix, decimal OthersPenOverStay, decimal OthersDisPwdSen) GetRatesAndPenaltiesFlatrate()
        {
            return (RateFlatEntry, OthersPenLossTix, OthersPenOverStay, OthersDisPwdSen);
        }

        public static void InsertTimeOutForFlatrate(string plateNumber, DateTime timeOut, bool isTicketLost, bool isDiscountApplied)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Get the final rate
                decimal rate = CalculateUpdatedRateFlatrate(plateNumber, isTicketLost, isDiscountApplied, timeOut);

                // Update the record in Flatrate_raw
                SqlCommand command = new SqlCommand("UPDATE Flatrate_raw SET TimeOut = @TimeOut, Rate = @Rate WHERE plateNumber = @PlateNumber", connection);
                command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                command.Parameters.AddWithValue("@TimeOut", timeOut);
                command.Parameters.AddWithValue("@Rate", rate);
                command.ExecuteNonQuery();
            }
        }

        public static decimal CalculateUpdatedRateFlatrate(string plateNumber, bool isTicketLost, bool isDiscountApplied, DateTime? timeOut = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Retrieve rate and penalty values from the database
                var (rate_flat_entry, others_pen_loss_tix, others_pen_over_stay, others_dis_pwdsen) = GetRatesAndPenaltiesFlatrate();

                // Get TimeIn from Flatrate_raw
                SqlCommand durationCommand = new SqlCommand("SELECT TimeIn FROM Flatrate_raw WHERE plateNumber = @PlateNumber", connection);
                durationCommand.Parameters.AddWithValue("@PlateNumber", plateNumber);
                DateTime timeIn = (DateTime)durationCommand.ExecuteScalar();

                if (timeOut == null)
                {
                    timeOut = DateTime.Now; // Assuming you want to use the current time as the TimeOut if not provided
                }
                TimeSpan duration = timeOut.Value - timeIn;

                // Calculate the rate
                decimal rate = rate_flat_entry;

                


                // Then, add the penalty for lost ticket if applicable
                if (isTicketLost)
                {
                    rate += others_pen_loss_tix;
                }

                DateTime penaltyTime = new DateTime(timeIn.Year, timeIn.Month, timeIn.Day, 21, 0, 0);
                if (timeOut > penaltyTime)
                {
                    rate += others_pen_over_stay;
                }

                // First, apply the discount if applicable
                if (isDiscountApplied)
                {
                    rate = rate - (decimal)((rate * others_dis_pwdsen) / 100);
                    if (rate < 0) rate = 0; // Ensure rate doesn't go negative
                }

                return rate;
            }
        }




        public static string GetPlaceForPlateNumberFlatrate(string plateNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT place FROM Flatrate_raw WHERE plateNumber = @PlateNumber", connection);
                command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                return command.ExecuteScalar()?.ToString();
            }
        }//to get the place of the selected vehicle

        
        public static void IncrementPlaceValueFlatrate(string selectedPlace)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand fetchPlaceValueCommand = new SqlCommand($"SELECT {selectedPlace} FROM parking_place", connection);
                int currentValue = (int)fetchPlaceValueCommand.ExecuteScalar();
                SqlCommand updatePlaceCommand = new SqlCommand($"UPDATE parking_place SET {selectedPlace} = @NewValue", connection);
                updatePlaceCommand.Parameters.AddWithValue("@NewValue", currentValue + 1); // Incrementing the value
                updatePlaceCommand.ExecuteNonQuery();
            }
        }//to free up space


        public static void InsertFlatrateLog(int id, string plateNumber, string name, string vehicleType, DateTime timeIn, DateTime timeOut, decimal rate, string place, string discountInfo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Flatrate_log (id, plateNumber, name, vehicleType, TimeIn, TimeOut, Rate, place, discountInfo) VALUES (@Id, @PlateNumber, @Name, @VehicleType, @TimeIn, @TimeOut, @Rate, @Place, @DiscountInfo)", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@VehicleType", vehicleType);
                command.Parameters.AddWithValue("@TimeIn", timeIn);
                command.Parameters.AddWithValue("@TimeOut", timeOut);
                command.Parameters.AddWithValue("@Rate", rate);
                command.Parameters.AddWithValue("@Place", place);
                command.Parameters.AddWithValue("@DiscountInfo", discountInfo ?? (object)DBNull.Value);

                command.ExecuteNonQuery();
            }
        }



        public static DataTable GetAllPlateNumbersFlatrateLog()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, plateNumber, name, vehicleType, TimeIn, TimeOut, Rate, place FROM Flatrate_log", connection);
                adapter.Fill(dt);
            }
            return dt;
        }//Retrieves all flatrate parking log records.


        //use this to see just the timeouts for the current day
        public static DataTable GetCurrentDayTimeoutsFlatrate()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Modify the SQL query to format TimeIn and TimeOut as desired
                string query = @"
                SELECT id, plateNumber, name, vehicleType, 
                FORMAT(TimeIn, 'MMMM dd HH:mm:ss') AS TimeIn, 
                FORMAT(TimeOut, 'MMMM dd HH:mm:ss') AS TimeOut, 
                Rate, place 
                FROM flatrate_log 
                WHERE CAST(TimeOut AS DATE) = CAST(GETDATE() AS DATE)";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
            }
            return dt;
        }






        public static int DeleteFromFlatrateRaw(string plateNumber)
        {
            int id = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // First, retrieve the id for the given plateNumber
                using (SqlCommand getIdCmd = new SqlCommand("SELECT id FROM Flatrate_raw WHERE PlateNumber = @PlateNumber", conn))
                {
                    getIdCmd.Parameters.AddWithValue("@PlateNumber", plateNumber);
                    id = Convert.ToInt32(getIdCmd.ExecuteScalar());
                }

                // Then delete the record
                using (SqlCommand deleteCmd = new SqlCommand("DELETE FROM Flatrate_raw WHERE PlateNumber = @PlateNumber", conn))
                {
                    deleteCmd.Parameters.AddWithValue("@PlateNumber", plateNumber);
                    deleteCmd.ExecuteNonQuery();
                }
            }

            return id;
        } //Deletes a flatrate parking record.

        //--------------------------- FOR FLATRATE SECTION ---------------------------//


        //--------------------------- FOR CASUAL SECTION ---------------------------//
        public static bool InsertPlateNumberCasual(string plateNumber, string name, string vehicleType, DateTime timeIn)
        {
            string selectedPlace = ChooseRandomPlaceCasual(vehicleType);
            if (string.IsNullOrEmpty(selectedPlace))
            {
                // No suitable place found
                return false;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Fetch the current value of the selected place
                SqlCommand fetchPlaceValueCommand = new SqlCommand($"SELECT {selectedPlace} FROM parking_place", connection);
                int currentValue = (int)fetchPlaceValueCommand.ExecuteScalar();

                if (currentValue <= 0) // Check if there are no available spots
                {
                    // Since the current place is full, call the function recursively to find another place
                    return InsertPlateNumberCasual(plateNumber, name, vehicleType, timeIn);
                }

                // Insert into Casual_raw table
                SqlCommand command = new SqlCommand("INSERT INTO Casual_raw(plateNumber, name, vehicleType, TimeIn, place) VALUES (@PlateNumber, @Name, @VehicleType, @TimeIn, @Place)", connection);
                command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@VehicleType", vehicleType);
                command.Parameters.AddWithValue("@TimeIn", timeIn);
                command.Parameters.AddWithValue("@Place", selectedPlace);
                command.ExecuteNonQuery();

                // Update the parking_place table to decrement the current capacity for the selected place
                SqlCommand updatePlaceCommand = new SqlCommand($"UPDATE parking_place SET {selectedPlace} = @NewValue", connection);
                updatePlaceCommand.Parameters.AddWithValue("@NewValue", currentValue - 1);
                updatePlaceCommand.ExecuteNonQuery();
            }

            return true;
        }//Inserts a new casual parking record with plate number, name, vehicle type, and time in.



        public static string ChooseRandomPlaceCasual(string vehicleType)
        {
            List<string> places;
            if (vehicleType == "CAR")
            {
                places = new List<string> { "C1", "C2", "C3", "C4", "C5", "C6" };
            }
            else if (vehicleType == "TRICYCLE")
            {
                places = new List<string> { "T1", "T2" };
            }
            else
            {
                return null; // Unrecognized vehicle type
            }

            Random random = new Random();
            places = places.OrderBy(x => random.Next()).ToList(); // Shuffle the places list

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string placeQuery = string.Join(", ", places);
                SqlCommand command = new SqlCommand($"SELECT {placeQuery} FROM parking_place", connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // Iterate through the shuffled places
                    foreach (string place in places)
                    {
                        // Check the available space for the randomly selected place
                        if (reader.GetInt32(places.IndexOf(place)) > 0)
                        {
                            return place; // Return the random place that has space available
                        }
                    }
                }
            }

            return null; // No suitable place found
        }



        public static DataTable GetAllPlateNumbersCasual()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Include the "place" column in the SELECT statement
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, plateNumber, name, vehicleType, CONVERT(varchar, TimeIn, 108) AS TimeIn, TimeOut, Rate, place FROM Casual_raw", connection);
                adapter.Fill(dt);

                // Modify the format of the TimeIn column to display only hours, minutes, and seconds
                foreach (DataRow row in dt.Rows)
                {
                    if (row["TimeIn"] != DBNull.Value)
                    {
                        row["TimeIn"] = DateTime.Parse(row["TimeIn"].ToString()).ToString("MMMM dd HH:mm:ss");
                    }
                }
            }
            return dt;
        }//Retrieves all flatrate parking records.

        public static void UpdatePlateNumberCasual(string oldPlateNumber, string newPlateNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UPDATE Casual_raw SET plateNumber = @newPlateNumber WHERE plateNumber = @oldPlateNumber", connection))
                {
                    command.Parameters.AddWithValue("@newPlateNumber", newPlateNumber);
                    command.Parameters.AddWithValue("@oldPlateNumber", oldPlateNumber);

                    command.ExecuteNonQuery();
                }
            }
        }//Updates the plate number of a casual parking record.





        public static DataRow GetCasualRecordById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Casual_raw WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                return null;
            }
        }

        public static DataRow GetCasualRecordByIdLog(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Casual_log WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                return null;
            }
        }

        public static (decimal RateCasTwoHours, decimal OthersPenLossTix, decimal OthersPenOverStay, decimal OthersDisPwdSen) GetRatesAndPenaltiesCasual()
        {
            return (RateFlatEntry, OthersPenLossTix, OthersPenOverStay, OthersDisPwdSen);
        }


        public static void InsertTimeOutForCasual(string plateNumber, DateTime timeOut, bool isDiscountApplied, bool isTicketLost)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Get the final rate
                decimal rate = CalculateUpdatedRateCasual(plateNumber, isTicketLost, isDiscountApplied, timeOut);

                // Update the record in Flatrate_raw
                SqlCommand command = new SqlCommand("UPDATE Casual_raw SET TimeOut = @TimeOut, Rate = @Rate WHERE plateNumber = @PlateNumber", connection);
                command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                command.Parameters.AddWithValue("@TimeOut", timeOut);
                command.Parameters.AddWithValue("@Rate", rate);
                command.ExecuteNonQuery();
            }
        }//Inserts the time out value for a casual parking record and calculates the rate based on the duration.



        public static decimal CalculateUpdatedRateCasual(string plateNumber, bool isTicketLost, bool isDiscountApplied, DateTime? timeOut = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Retrieve rate and penalty values from the database
                var (rate_flat_entry, others_pen_loss_tix, others_pen_over_stay, others_dis_pwdsen) = GetRatesAndPenaltiesCasual();

                // Get TimeIn from Casual_raw
                SqlCommand durationCommand = new SqlCommand("SELECT TimeIn FROM Casual_raw WHERE plateNumber = @PlateNumber", connection);
                durationCommand.Parameters.AddWithValue("@PlateNumber", plateNumber);
                DateTime timeIn = (DateTime)durationCommand.ExecuteScalar();

                if (timeOut == null)
                {
                    timeOut = DateTime.Now;
                }

                TimeSpan duration = timeOut.Value - timeIn;

                decimal rate = 0;  // Initialize to zero for casual parking

                // If the parking duration is 10 minutes or less, return the rate as 0.
                if (duration.TotalMinutes <= 10)
                {
                    return rate;
                }

                if (duration.TotalHours <= 2)
                {
                    rate = RateCasTwoHours;
                }
                else
                {
                    rate = RateCasTwoHours;
                    double extraHours = Math.Ceiling(duration.TotalHours - 2);
                    rate += RateCasSucHours * (decimal)extraHours;
                }


                decimal rateWithPenalties = rate;

                // Add penalty for lost ticket, if applicable
                if (isTicketLost)
                {
                    rateWithPenalties += others_pen_loss_tix;
                }

                // Add penalty for overstay (operation hours 8 am to 9 pm)
                DateTime penaltyTime = new DateTime(timeIn.Year, timeIn.Month, timeIn.Day, 21, 0, 0);
                if (timeOut > penaltyTime)
                {
                    rateWithPenalties += others_pen_over_stay;
                }

                // Apply discount, if applicable
                if (isDiscountApplied)
                {
                    decimal discountAmount = (rateWithPenalties * others_dis_pwdsen) / 100m;

                    rateWithPenalties -= discountAmount;

                    if (rateWithPenalties < 0) rateWithPenalties = 0; // Ensure rate doesn't go negative
                }

                return rateWithPenalties;
            }
        }


        public static string GetPlaceForPlateNumberCasual(string plateNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT place FROM Casual_raw WHERE plateNumber = @PlateNumber", connection);
                command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                return command.ExecuteScalar()?.ToString();
            }
        }



        public static void IncrementPlaceValueCasual(string selectedPlace)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Forming the SQL command to fetch the current value
                SqlCommand fetchPlaceValueCommand = new SqlCommand($"SELECT [{selectedPlace}] FROM parking_place", connection);

                // Execute the command and retrieve the current value
                object result = fetchPlaceValueCommand.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int currentValue))
                {
                    // Forming the SQL command to update the value
                    SqlCommand updatePlaceCommand = new SqlCommand($"UPDATE parking_place SET [{selectedPlace}] = @NewValue", connection);
                    updatePlaceCommand.Parameters.AddWithValue("@NewValue", currentValue + 1); // Incrementing the value

                    updatePlaceCommand.ExecuteNonQuery();
                }
                else
                {
                    // Handle the error case when the result is null or not an integer
                    // You may want to throw an exception or log an error
                }
            }
        }



        public static void InsertCasualLog(int id, string plateNumber, string name, string vehicleType, DateTime timeIn, DateTime timeOut, decimal rate, string place, string discountInfo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Casual_log (id, plateNumber, name, vehicleType, TimeIn, TimeOut, Rate, place, discountInfo) VALUES (@Id, @PlateNumber, @Name, @VehicleType, @TimeIn, @TimeOut, @Rate, @Place, @DiscountInfo)", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@VehicleType", vehicleType);
                command.Parameters.AddWithValue("@TimeIn", timeIn);
                command.Parameters.AddWithValue("@TimeOut", timeOut);
                command.Parameters.AddWithValue("@Rate", rate);
                command.Parameters.AddWithValue("@Place", place);
                command.Parameters.AddWithValue("@DiscountInfo", discountInfo ?? (object)DBNull.Value);

                command.ExecuteNonQuery();
            }
        }//Inserts a casual parking record into the log.

        public static DataTable GetAllPlateNumbersCasualLog()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Change the SQL query to use CONVERT function to get only the time portion
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, plateNumber, name, vehicleType, CONVERT(varchar, TimeIn, 108) AS TimeIn, CONVERT(varchar, TimeOut, 108) AS TimeOut, Rate, place FROM Casual_log", connection);
                adapter.Fill(dt);
            }
            return dt;
        } //Retrieves all casual parking log records.





        //use this to see just the timeouts for the current day
        public static DataTable GetCurrentDayTimeoutsCasual()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Modify the SQL query to format TimeIn and TimeOut as desired
                string query = @"
                SELECT id, plateNumber, name, vehicleType, 
                FORMAT(TimeIn, 'MMMM dd HH:mm:ss') AS TimeIn, 
                FORMAT(TimeOut, 'MMMM dd HH:mm:ss') AS TimeOut, 
                Rate, place 
                FROM casual_log 
                WHERE CAST(TimeOut AS DATE) = CAST(GETDATE() AS DATE)";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
            }
            return dt;
        }





        public static int DeleteFromCasualRaw(string plateNumber)
        {
            int id = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // First, retrieve the id for the given plateNumber
                using (SqlCommand getIdCmd = new SqlCommand("SELECT id FROM Casual_raw WHERE PlateNumber = @PlateNumber", conn))
                {
                    getIdCmd.Parameters.AddWithValue("@PlateNumber", plateNumber);
                    id = Convert.ToInt32(getIdCmd.ExecuteScalar());
                }

                // Then delete the record
                using (SqlCommand deleteCmd = new SqlCommand("DELETE FROM Casual_raw WHERE PlateNumber = @PlateNumber", conn))
                {
                    deleteCmd.Parameters.AddWithValue("@PlateNumber", plateNumber);
                    deleteCmd.ExecuteNonQuery();
                }
            }

            return id;
        }
        //Deletes a casual parking record.

        //--------------------------- FOR CASUAL SECTION ---------------------------//


        //--------------------------- FOR EMPLOYEE LOGIN ---------------------------//
        public int? VerifyEmployeeCredentials(string inputUsername, string inputPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT empId, empPass FROM employee_info WHERE empUser = @Username";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", inputUsername);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string correctPassword = reader["empPass"].ToString();

                            if (inputPassword == correctPassword)
                            {
                                // Credentials are correct
                                return Convert.ToInt32(reader["empId"]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during database connection or query execution
                }

                return null; // Invalid credentials or database error
            }
        }



        public bool IsUsernameValid(string username)
        {
            // Assuming you have a database connection established (e.g., using SqlConnection for SQL Server)
            using (var connection = new SqlConnection(connectionString))
            {
                // Replace 'YourUsersTableName' and 'UsernameColumn' with your actual table and column names
                string query = "SELECT COUNT(*) FROM employee_info WHERE empUser= @username";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    try
                    {
                        connection.Open();
                        int userCount = (int)command.ExecuteScalar();

                        // If the count is 0, username does not exist; otherwise, it exists
                        return userCount > 0;
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions (e.g., logging)
                        // For simplicity, returning false here but you might want to handle it differently
                        return false;
                    }
                }
            }
        }


        public string GetUserShift(string username)
        {
            string shift = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT shift FROM employee_info WHERE empUser = @username", connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            shift = reader["shift"] as string; // Assuming 'shift' is the column name in your table
                        }
                    }
                }
            }

            return shift;
        }







        //--------------------------- FOR EMPLOYEE LOGIN ---------------------------//


        //--------------------------- FOR ADMIN LOGIN ---------------------------//
        public bool VerifyAdminCredentials(string inputUsername, string inputPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT adminUser, adminPass FROM admin_info WHERE adminUser = @Username";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", inputUsername);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string correctUsername = reader["adminUser"].ToString();
                            string correctPassword = reader["adminPass"].ToString();

                            if (inputPassword == correctPassword)
                            {
                                // Credentials are correct
                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during database connection or query execution
                }

                return false; // Invalid credentials or database error
            }
        }
        //--------------------------- FOR ADMIN LOGIN ---------------------------//


        //--------------------------- FOR MANAGE RATES ---------------------------//

        // Declare variables so pede magamit sa ibang methods
        public static decimal RateCasTwoHours { get; private set; }
        public static decimal RateCasSucHours { get; private set; }
        public static decimal RateFlatEntry { get; private set; }
        public static decimal OthersPenLossTix { get; private set; }
        public static decimal OthersPenOverStay { get; private set; }
        public static decimal OthersDisPwdSen { get; private set; }

        // To get the value from the database
        public void FetchRates()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM rates", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            RateCasTwoHours = (decimal)reader["rate_cas_two_hours"];
                            RateCasSucHours = (decimal)reader["rate_cas_suc_hours"];
                            RateFlatEntry = (decimal)reader["rate_flat_entry"];
                            OthersPenLossTix = (decimal)reader["others_pen_loss_tix"];
                            OthersPenOverStay = (decimal)reader["others_pen_over_stay"];
                            OthersDisPwdSen = (decimal)reader["others_dis_pwdsen"];
                        }
                    }
                }
            }
        }

        // To update the value
        public static void UpdateRate(string fieldName, decimal newValue)
        {
            string sqlColumn = "";
            switch (fieldName)
            {
                case "RateCasTwoHours":
                    RateCasTwoHours = (decimal)newValue;
                    sqlColumn = "rate_cas_two_hours";
                    break;
                case "RateCasSucHours":
                    RateCasSucHours = (int)newValue;
                    sqlColumn = "rate_cas_suc_hours";
                    break;
                case "RateFlatEntry":
                    RateFlatEntry = (int)newValue;
                    sqlColumn = "rate_flat_entry";
                    break;
                case "OthersPenLossTix":
                    OthersPenLossTix = (int)newValue;
                    sqlColumn = "others_pen_loss_tix";
                    break;
                case "OthersPenOverStay":
                    OthersPenOverStay = (int)newValue;
                    sqlColumn = "others_pen_over_stay";
                    break;
                case "OthersDisPwdSen":
                    OthersDisPwdSen = (decimal)newValue;
                    sqlColumn = "others_dis_pwdsen";
                    break;
                default:
                    throw new ArgumentException("Invalid field name");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand($"UPDATE rates SET {sqlColumn} = @value", connection))
                {
                    command.Parameters.AddWithValue("@value", newValue);
                    command.ExecuteNonQuery();
                }
            }
        }
        //--------------------------- FOR MANAGE RATES ---------------------------//

        //--------------------------- FOR EMPLOYEE RECORDS ---------------------------//

        //Load data
        public static Employee GetEmployeeById(int empId)
        {
            Employee emp = new Employee();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM employee_info WHERE empID = @empId", connection))
                {
                    cmd.Parameters.AddWithValue("@empId", empId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            emp.empID = (int)reader["empID"];
                            emp.empUser = reader["empUser"] is DBNull ? null : reader["empUser"].ToString();
                            emp.empPass = reader["empPass"] is DBNull ? null : reader["empPass"].ToString();
                            emp.empFirstName = reader["empFirstName"] is DBNull ? null : reader["empFirstName"].ToString();
                            emp.empMiddleName = reader["empMiddleName"] is DBNull ? null : reader["empMiddleName"].ToString();
                            emp.empLastName = reader["empLastName"] is DBNull ? null : reader["empLastName"].ToString();
                            emp.jobDesc = reader["jobDesc"] is DBNull ? null : reader["jobDesc"].ToString();
                            emp.shift = reader["shift"] is DBNull ? null : reader["shift"].ToString();
                            emp.empImg = reader["empImg"] is DBNull ? null : (byte[])reader["empImg"];
                        }
                    }
                }
            }
            return emp;
        }

        public static void ResetEmployeeById(int empId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE employee_info SET empUser = NULL, empPass = NULL, empFirstName = NULL, empMiddleName = NULL, empLastName = NULL, jobDesc = NULL, shift = NULL, empImg = NULL WHERE empID = @empId", connection))
                {
                    cmd.Parameters.AddWithValue("@empId", empId);
                    cmd.ExecuteNonQuery();
                }
            }
        }//reset

        public static void ResetAllEmployees()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE employee_info SET empUser = NULL, empPass = NULL, empFirstName = NULL, empMiddleName = NULL, empLastName = NULL, jobDesc = NULL, shift = NULL, empImg = NULL", connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }//clear all


        //Update Data
        public static void UpdateEmployee(Employee emp)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE employee_info SET empUser = @empUser, empPass = @empPass, empFirstName = @empFirstName, empMiddleName = @empMiddleName, empLastName = @empLastName, jobDesc = @jobDesc, shift = @shift, empImg = @empImg WHERE empID = @empID", connection))
                {
                    cmd.Parameters.AddWithValue("@empUser", string.IsNullOrEmpty(emp.empUser) ? DBNull.Value : (object)emp.empUser);
                    cmd.Parameters.AddWithValue("@empPass", string.IsNullOrEmpty(emp.empPass) ? DBNull.Value : (object)emp.empPass);
                    cmd.Parameters.AddWithValue("@empFirstName", string.IsNullOrEmpty(emp.empFirstName) ? DBNull.Value : (object)emp.empFirstName);
                    cmd.Parameters.AddWithValue("@empMiddleName", string.IsNullOrEmpty(emp.empMiddleName) ? DBNull.Value : (object)emp.empMiddleName);
                    cmd.Parameters.AddWithValue("@empLastName", string.IsNullOrEmpty(emp.empLastName) ? DBNull.Value : (object)emp.empLastName);
                    cmd.Parameters.AddWithValue("@jobDesc", string.IsNullOrEmpty(emp.jobDesc) ? DBNull.Value : (object)emp.jobDesc);
                    cmd.Parameters.AddWithValue("@shift", string.IsNullOrEmpty(emp.shift) ? DBNull.Value : (object)emp.shift);

                    if (emp.empImg != null)
                    {
                        cmd.Parameters.Add("@empImg", SqlDbType.VarBinary).Value = emp.empImg;
                    }
                    else
                    {
                        cmd.Parameters.Add("@empImg", SqlDbType.VarBinary).Value = DBNull.Value;
                    }

                    cmd.Parameters.AddWithValue("@empID", emp.empID);

                    cmd.ExecuteNonQuery();
                }
            }
        }




        // For Shift Summary
        public static bool GetShiftDetails(out CoordinatorDetails morningA, out CoordinatorDetails morningB, out CoordinatorDetails afternoonA, out CoordinatorDetails afternoonB)
        {
            // Assume connectionString is defined elsewhere in your class
            // connectionString = "your_connection_string";

            // Initialize all out parameters to null
            morningA = morningB = afternoonA = afternoonB = null;

            // If a backup or restore is in progress, return false immediately
            if (IsBackupOrRestoreInProgress)
            {
                return false;
            }

            // Variables to keep track of each shift and coordinator
            int morningCount = 0, afternoonCount = 0, coordinatorACount = 0, coordinatorBCount = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM employee_info", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string shift = reader["shift"] is DBNull ? null : reader["shift"].ToString();
                            string jobDesc = reader["jobDesc"] is DBNull ? null : reader["jobDesc"].ToString();
                            byte[] img = reader["empImg"] is DBNull ? null : (byte[])reader["empImg"];
                            string firstName = reader["empFirstName"] is DBNull ? null : reader["empFirstName"].ToString();
                            string middleName = reader["empMiddleName"] is DBNull ? null : reader["empMiddleName"].ToString();
                            string lastName = reader["empLastName"] is DBNull ? null : reader["empLastName"].ToString();

                            // If middle name is not empty, get the initial
                            middleName = !string.IsNullOrEmpty(middleName) ? middleName.Substring(0, 1) + "." : string.Empty;

                            CoordinatorDetails coordinator = new CoordinatorDetails
                            {
                                Image = img,
                                FirstName = firstName,
                                MiddleName = middleName,
                                LastName = lastName
                            };

                            // Assign coordinators based on shift and job description
                            if (shift == "Morning")
                            {
                                morningCount++;
                                if (jobDesc == "Entry Lead") { morningA = coordinator; coordinatorACount++; }
                                if (jobDesc == "Exit Lead") { morningB = coordinator; coordinatorBCount++; }
                            }
                            else if (shift == "Afternoon")
                            {
                                afternoonCount++;
                                if (jobDesc == "Entry Lead") { afternoonA = coordinator; coordinatorACount++; }
                                if (jobDesc == "Exit Lead") { afternoonB = coordinator; coordinatorBCount++; }
                            }
                        }
                    }
                }
            }

            // Check if the counts are as expected before returning true
            bool isValid = morningCount == 2 && afternoonCount == 2 && coordinatorACount == 2 && coordinatorBCount == 2;
            return isValid;
        }



        //--------------------------- UPDATES AFTER CONSULTATION ---------------------------//
        // Updated method to exclude records where shift or jobDesc are null
        public static int GetEmployeeCountByShift(string shift)
        {
            try
            {
                int count = 0;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM employee_info WHERE shift = @shift", conn))
                    {
                        cmd.Parameters.AddWithValue("@shift", shift);
                        count = (int)cmd.ExecuteScalar();
                    }
                }
                return count;
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception in GetEmployeeCountByShift: " + e.Message);
                return 0; // Return 0 if an exception occurs
            }
        }






        public static int GetEmployeeCountByRoleAndShift(string role, string shift)
        {
            int count = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM employee_info WHERE shift = @shift AND jobDesc = @role";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@shift", shift);
                    command.Parameters.AddWithValue("@role", role);

                    count = (int)command.ExecuteScalar();
                }
            }

            return count;
        }





        //fix job and shift
        public static List<Employee> FetchEmployeesWithNonNullJobDescAndShift()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM employee_info WHERE jobDesc IS NOT NULL AND shift IS NOT NULL", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee emp = new Employee();
                            emp.empID = (int)reader["empID"];
                            emp.empUser = reader["empUser"] is DBNull ? null : reader["empUser"].ToString();
                            emp.empPass = reader["empPass"] is DBNull ? null : reader["empPass"].ToString();
                            emp.empFirstName = reader["empFirstName"] is DBNull ? null : reader["empFirstName"].ToString();
                            emp.empMiddleName = reader["empMiddleName"] is DBNull ? null : reader["empMiddleName"].ToString();
                            emp.empLastName = reader["empLastName"] is DBNull ? null : reader["empLastName"].ToString();
                            emp.jobDesc = reader["jobDesc"] is DBNull ? null : reader["jobDesc"].ToString();
                            emp.shift = reader["shift"] is DBNull ? null : reader["shift"].ToString();
                            emp.empImg = reader["empImg"] is DBNull ? null : (byte[])reader["empImg"];
                            employees.Add(emp);
                        }
                    }
                }
            }
            return employees;
        }


        //update the shift and job
        public static void UpdateEmployeeShiftAndJob(int empId, string shift, string jobDesc)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE employee_info SET shift = @shift, jobDesc = @jobDesc WHERE empID = @empId", connection))
                {
                    cmd.Parameters.AddWithValue("@empId", empId);
                    cmd.Parameters.AddWithValue("@shift", shift);
                    cmd.Parameters.AddWithValue("@jobDesc", jobDesc);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        //choose employee with no null value on job and shift
        public static List<Employee> GetEmployeesWithJobAndShift()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM employee_info WHERE jobDesc IS NOT NULL AND shift IS NOT NULL", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee emp = new Employee();
                            emp.empID = (int)reader["empID"];
                            emp.empUser = reader["empUser"] is DBNull ? null : reader["empUser"].ToString();
                            emp.empPass = reader["empPass"] is DBNull ? null : reader["empPass"].ToString();
                            emp.empFirstName = reader["empFirstName"] is DBNull ? null : reader["empFirstName"].ToString();
                            emp.empMiddleName = reader["empMiddleName"] is DBNull ? null : reader["empMiddleName"].ToString();
                            emp.empLastName = reader["empLastName"] is DBNull ? null : reader["empLastName"].ToString();
                            emp.jobDesc = reader["jobDesc"] is DBNull ? null : reader["jobDesc"].ToString();
                            emp.shift = reader["shift"] is DBNull ? null : reader["shift"].ToString();
                            emp.empImg = reader["empImg"] is DBNull ? null : (byte[])reader["empImg"];

                            employees.Add(emp);
                        }
                    }
                }
            }
            return employees;
        }

        //swap job and sched
        public static void SwapEmployeeDetails(int empId1, int empId2)
        {
            Employee emp1 = GetEmployeeById(empId1);
            Employee emp2 = GetEmployeeById(empId2);

            string tempJobDesc = emp1.jobDesc;
            string tempShift = emp1.shift;

            emp1.jobDesc = emp2.jobDesc;
            emp1.shift = emp2.shift;

            emp2.jobDesc = tempJobDesc;
            emp2.shift = tempShift;

            // Update the database
            UpdateEmployee(emp1);
            UpdateEmployee(emp2);
        }



        //substitute employee info
        public static void SaveSubstituteState(
        int SubstitutedEmployeeId1, int SubstitutedEmployeeId2,
        int SubstituteEmployeeId1, int SubstituteEmployeeId2,
        bool isSubstitute1Deployed, bool isSubstitute2Deployed)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Assuming you have only one row that keeps the state
                using (SqlCommand cmd = new SqlCommand("DELETE FROM substitute_employee", connection))
                {
                    cmd.ExecuteNonQuery();
                }

                // Now insert new state
                using (SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO substitute_employee(
                    SubstitutedEmployeeId1, SubstitutedEmployeeId2,
                    SubstituteEmployeeId1, SubstituteEmployeeId2,
                    isSubstitute1Deployed, isSubstitute2Deployed)
                    VALUES (@sub1, @sub2, @subs1, @subs2, @isSub1, @isSub2)", connection))
                    {
                    cmd.Parameters.AddWithValue("@sub1", SubstitutedEmployeeId1);
                    cmd.Parameters.AddWithValue("@sub2", SubstitutedEmployeeId2);
                    cmd.Parameters.AddWithValue("@subs1", SubstituteEmployeeId1);
                    cmd.Parameters.AddWithValue("@subs2", SubstituteEmployeeId2);
                    cmd.Parameters.AddWithValue("@isSub1", isSubstitute1Deployed);
                    cmd.Parameters.AddWithValue("@isSub2", isSubstitute2Deployed);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static (int, int, int, int, bool, bool) LoadSubstituteState()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM substitute_employee", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (
                                (int)reader["SubstitutedEmployeeId1"],
                                (int)reader["SubstitutedEmployeeId2"],
                                (int)reader["SubstituteEmployeeId1"],
                                (int)reader["SubstituteEmployeeId2"],
                                (bool)reader["isSubstitute1Deployed"],
                                (bool)reader["isSubstitute2Deployed"]
                            );
                        }
                    }
                }
            }
            return (0, 0, 0, 0, false, false); // Default state
        }

        public static bool IsAnySubstituteDeployed()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM substitute_employee", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bool isSubstitute1Deployed = (bool)reader["isSubstitute1Deployed"];
                            bool isSubstitute2Deployed = (bool)reader["isSubstitute2Deployed"];
                            return isSubstitute1Deployed || isSubstitute2Deployed;
                        }
                    }
                }
            }
            return false; // Default state
        }



        //--------------------------- UPDATES AFTER CONSULTATION ---------------------------//




        //--------------------------- FOR EMPLOYEE RECORDS ---------------------------//


        //--------------------------- FOR PARKING LOT MAP ---------------------------//
        public ParkingPlace GetParkingPlaceData()
        {
            ParkingPlace parkingPlace = new ParkingPlace();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM parking_place"; // modify as needed
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        //flatrate
                        parkingPlace.mt1 = reader.GetInt32(reader.GetOrdinal("mt1"));
                        parkingPlace.mt2 = reader.GetInt32(reader.GetOrdinal("mt2"));
                        parkingPlace.mt3 = reader.GetInt32(reader.GetOrdinal("mt3"));

                        //casual
                        parkingPlace.c1 = reader.GetInt32(reader.GetOrdinal("c1"));
                        parkingPlace.c2 = reader.GetInt32(reader.GetOrdinal("c2"));
                        parkingPlace.c3 = reader.GetInt32(reader.GetOrdinal("c3"));
                        parkingPlace.c4 = reader.GetInt32(reader.GetOrdinal("c4"));
                        parkingPlace.c5 = reader.GetInt32(reader.GetOrdinal("c5"));
                        parkingPlace.c6 = reader.GetInt32(reader.GetOrdinal("c6"));
                        //trisikol
                        parkingPlace.t1 = reader.GetInt32(reader.GetOrdinal("t1"));
                        parkingPlace.t2 = reader.GetInt32(reader.GetOrdinal("t2"));


                    }
                }
            }

            return parkingPlace;
        }//get the values


        //--------------------------- FOR PARKING LOT MAP ---------------------------//


        //--------------------------- REFRESHER ---------------------------//

        //pag nag click sa in or out ma rerefresh on both pc
        public static DateTime? GetRefreshTimestamp()
        {
            // If a backup or restore is in progress, return null or throw exception
            if (IsBackupOrRestoreInProgress)
            {
                return null; // or throw new InvalidOperationException("Backup or restore is in progress.");
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT RefreshTimestamp FROM RefreshSignal", conn))
                {
                    return (DateTime)cmd.ExecuteScalar();
                }
            }
        }

        public static void UpdateRefreshTimestamp(DateTime newTimestamp)
        {
            // If a backup or restore is in progress, return or throw exception
            if (IsBackupOrRestoreInProgress)
            {
                throw new InvalidOperationException("Backup or restore is in progress.");
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE RefreshSignal SET RefreshTimestamp = @timestamp", conn))
                {
                    cmd.Parameters.AddWithValue("@timestamp", newTimestamp);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        //para sa login page
        public static DateTime? GetRefreshTimestampAdmin()
        {
            // If a backup or restore is in progress, return null or throw exception
            if (IsBackupOrRestoreInProgress)
            {
                return null; // or throw new InvalidOperationException("Backup or restore is in progress.");
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT RefreshTimestampAdmin FROM RefreshSignal", conn))
                {
                    return (DateTime)cmd.ExecuteScalar();
                }
            }
        }

        public static void UpdateRefreshTimestampAdmin(DateTime newTimestamp)
        {
            // If a backup or restore is in progress, return or throw exception
            if (IsBackupOrRestoreInProgress)
            {
                throw new InvalidOperationException("Backup or restore is in progress.");
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE RefreshSignal SET RefreshTimestampAdmin = @timestamp", conn))
                {
                    cmd.Parameters.AddWithValue("@timestamp", newTimestamp);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        //--------------------------- REFRESHER ---------------------------//


        //--------------------------- SETTINGS ---------------------------//


        //panget daw tong function na to
        //inside parking lot
        public void ClearFlatrateRaw()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Delete the existing records (if that's still what you want to do)
                using (SqlCommand cmdDelete = new SqlCommand("DELETE FROM flatrate_raw", con))
                {
                    cmdDelete.ExecuteNonQuery();
                }

                // Update the fields to their default values
                string updateQuery = @"
                    UPDATE parking_place
                    SET
                    mt1 = 20,
                    mt2 = 15,
                    mt3 = 15";

                using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, con))
                {
                    cmdUpdate.ExecuteNonQuery();
                }
            }
        }


        public void ClearCasualRaw()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM casual_raw", con))
                {
                    cmd.ExecuteNonQuery();
                }

                // Update the fields to their default values
                string updateQuery = @"
                    UPDATE parking_place
                    SET
                    c1 = 8,
                    c2 = 8,
                    c3 = 8,
                    c4 = 8,
                    c5 = 8,
                    c6 = 10,
                    t1 = 10,
                    t2 = 10";

                using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, con))
                {
                    cmdUpdate.ExecuteNonQuery();
                }

            }
        }

        //log
        public void ClearFlatrateLog()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM flatrate_log", con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void ClearCasualLog()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM casual_log", con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }


        //edit login credentials
        public static event Action CredentialsUpdated;

        public static void OnCredentialsUpdated()
        {
            CredentialsUpdated?.Invoke();
        }


        public static (string, string, string, string, string) FetchAdminCredentials()
        {
            string username = "";
            string password = "";
            string fname = "";
            string mname = "";
            string lname = "";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM admin_info"; // Assume only one row of admin info
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        username = reader["adminUser"].ToString();
                        password = reader["adminPass"].ToString();
                        fname = reader["adminFname"].ToString();
                        mname = reader["adminMname"].ToString();
                        lname = reader["adminLname"].ToString();
                    }
                }
            }
            return (username, password, fname, mname, lname);
        }



        public static void UpdateAdminCredentials(string username, string password, string fname, string mname, string lname)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE admin_info SET adminUser = @username, adminPass = @password, adminFname = @fname, adminMname = @mname, adminLname = @lname";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@mname", mname);
                    cmd.Parameters.AddWithValue("@lname", lname);

                    cmd.ExecuteNonQuery();
                }
            }
        }




        public static void UpdateAdminUsername(string newUsername)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE admin_info SET adminUser = @newUsername";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@newUsername", newUsername);
                    cmd.ExecuteNonQuery();
                }
            }
            OnCredentialsUpdated();
        }

        public static void UpdateAdminPassword(string newPassword)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE admin_info SET adminPass = @newPassword";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@newPassword", newPassword);
                    cmd.ExecuteNonQuery();
                }
            }
            OnCredentialsUpdated();
        }

        //--------------------------- SETTINGS ---------------------------//


        //--------------------------- REPORT GENERATION ---------------------------//
        //daily
        public static DataTable GetParkingLogDataDaily(DateTime selectedDate)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                SELECT 'Flatrate' AS LogType, id, plateNumber, vehicleType, name, TimeIn, TimeOut, Rate, place, discountInfo
                FROM Flatrate_log 
                WHERE CAST(TimeIn AS DATE) = @selectedDate
                UNION ALL
                SELECT 'Casual' AS LogType, id, plateNumber, vehicleType, name, TimeIn, TimeOut, Rate, place, discountInfo
                FROM Casual_log 
                WHERE CAST(TimeIn AS DATE) = @selectedDate
                ORDER BY TimeIn";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@selectedDate", selectedDate.Date);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        //yung may mga discount lagn
        public static DataTable GetParkingLogDataWithDiscountDaily(DateTime selectedDate)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                SELECT 'Flatrate' AS LogType, id, plateNumber, vehicleType, name, TimeIn, TimeOut, Rate, place, discountInfo
                FROM Flatrate_log 
                WHERE CAST(TimeIn AS DATE) = @selectedDate AND discountInfo IS NOT NULL
                UNION ALL
                SELECT 'Casual' AS LogType, id, plateNumber, vehicleType, name, TimeIn, TimeOut, Rate, place, discountInfo
                FROM Casual_log 
                WHERE CAST(TimeIn AS DATE) = @selectedDate AND discountInfo IS NOT NULL
                ORDER BY TimeIn";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@selectedDate", selectedDate.Date);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }


        //overstay only 

        public static DataTable GetParkingLogDataOverstayDaily(DateTime selectedDate)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Define the operation hours
                TimeSpan operationStartTime = new TimeSpan(8, 0, 0); // 8 AM
                TimeSpan operationEndTime = new TimeSpan(21, 0, 0); // 9 PM
                DateTime operationEndDateTime = selectedDate.Date + operationEndTime;

                string query = @"
                SELECT 'Flatrate' AS LogType, id, plateNumber, vehicleType, name, TimeIn, TimeOut, Rate, place, discountInfo
                FROM Flatrate_log 
                WHERE CAST(TimeIn AS DATE) = @selectedDate AND TimeOut > @operationEndDateTime
                UNION ALL
                SELECT 'Casual' AS LogType, id, plateNumber, vehicleType, name, TimeIn, TimeOut, Rate, place, discountInfo
                FROM Casual_log 
                WHERE CAST(TimeIn AS DATE) = @selectedDate AND TimeOut > @operationEndDateTime
                ORDER BY TimeIn";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@selectedDate", selectedDate.Date);
                    cmd.Parameters.AddWithValue("@operationEndDateTime", operationEndDateTime);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }




        //for form total
        public static (int totalVehicles, double totalRevenue) GetTotals(DateTime selectedDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
            SELECT 
                COUNT(*) AS TotalVehicles, 
                SUM(Rate) AS TotalRevenue
            FROM (
                SELECT Rate FROM Flatrate_log WHERE CAST(TimeIn AS DATE) = @selectedDate
                UNION ALL
                SELECT Rate FROM Casual_log WHERE CAST(TimeIn AS DATE) = @selectedDate
            ) AS Combined";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@selectedDate", selectedDate.Date);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int totalVehicles = reader.GetInt32(0);
                            double totalRevenue = reader.IsDBNull(1) ? 0.0 : (double)reader.GetDecimal(1);
                            return (totalVehicles, totalRevenue);
                        }
                    }
                }
            }
            return (0, 0.0);
        }
        //daily


        //weekly
        public static DataTable GetParkingLogDataWeekly(DateTime selectedDate)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                SELECT 'Flatrate' AS LogType, id, plateNumber, vehicleType, name, TimeIn, TimeOut, Rate, place, discountInfo
                FROM Flatrate_log 
                WHERE CAST(TimeIn AS DATE) BETWEEN @startDate AND @endDate
                UNION ALL
                SELECT 'Casual' AS LogType, id, plateNumber, vehicleType, name, TimeIn, TimeOut, Rate, place, discountInfo
                FROM Casual_log 
                WHERE CAST(TimeIn AS DATE) BETWEEN @startDate AND @endDate
                ORDER BY TimeIn";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    DateTime startDate = selectedDate.Date;
                    DateTime endDate = startDate.AddDays(6); // Adding 6 days to include the entire week
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }


        //discount lang

        public static DataTable GetParkingLogDataWithDiscountWeekly(DateTime selectedDate)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DateTime startDate = selectedDate.Date.AddDays((int)selectedDate.Date.DayOfWeek);
                DateTime endDate = startDate.AddDays(6);

                string query = @"
                SELECT 'Flatrate' AS LogType, id, plateNumber, vehicleType,name, TimeIn, TimeOut, Rate, place, discountInfo
                FROM Flatrate_log 
                WHERE CAST(TimeIn AS DATE) BETWEEN @startDate AND @endDate AND discountInfo IS NOT NULL
                UNION ALL
                SELECT 'Casual' AS LogType, id, plateNumber, vehicleType,name, TimeIn, TimeOut, Rate, place, discountInfo
                FROM Casual_log 
                WHERE CAST(TimeIn AS DATE) BETWEEN @startDate AND @endDate AND discountInfo IS NOT NULL
                ORDER BY TimeIn";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }



        //overstay only
        public static DataTable GetParkingLogDataOverstayWeekly(DateTime selectedDate)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DateTime startDate = selectedDate.Date.AddDays(-(int)selectedDate.Date.DayOfWeek);
                DateTime endDate = startDate.AddDays(6);
                TimeSpan operationEndTime = new TimeSpan(21, 0, 0); // 9 PM

                string query = @"
                SELECT * FROM (
                    SELECT 'Flatrate' AS LogType, id, plateNumber, vehicleType, name, TimeIn, TimeOut, Rate, place, discountInfo
                    FROM Flatrate_log 
                    WHERE CAST(TimeIn AS DATE) BETWEEN @startDate AND @endDate
                    UNION ALL
                    SELECT 'Casual' AS LogType, id, plateNumber, vehicleType, name, TimeIn, TimeOut, Rate, place, discountInfo
                    FROM Casual_log 
                    WHERE CAST(TimeIn AS DATE) BETWEEN @startDate AND @endDate
                ) AS CombinedLogs
                WHERE CAST(TimeOut AS TIME) > @operationEndTime
                ORDER BY TimeIn";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    cmd.Parameters.AddWithValue("@operationEndTime", operationEndTime);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }




        public static (int totalVehicles, double totalRevenue) GetWeeklyTotals(DateTime selectedDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                SELECT 
                    COUNT(*) AS TotalVehicles, 
                    ISNULL(SUM(Rate), 0) AS TotalRevenue
                FROM (
                    SELECT Rate FROM Flatrate_log WHERE CAST(TimeIn AS DATE) BETWEEN @startDate AND @endDate
                    UNION ALL
                    SELECT Rate FROM Casual_log WHERE CAST(TimeIn AS DATE) BETWEEN @startDate AND @endDate
                ) AS Combined";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    DateTime startDate = selectedDate.Date;
                    DateTime endDate = startDate.AddDays(6); // Adding 6 days to include the entire week
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int totalVehicles = reader.GetInt32(0);
                            decimal totalRevenueDecimal = reader.GetDecimal(1);
                            double totalRevenue = (double)totalRevenueDecimal;
                            return (totalVehicles, totalRevenue);
                        }
                    }
                }
            }
            return (0, 0.0);
        }


        //weekly



        //monthly
        public static DataTable GetParkingLogDataMonthly(DateTime selectedMonth)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                SELECT 'Flatrate' AS LogType, id, plateNumber, vehicleType, name, TimeIn, TimeOut, Rate, place, discountInfo
                FROM Flatrate_log 
                WHERE MONTH(TimeIn) = @selectedMonth AND YEAR(TimeIn) = @selectedYear
                UNION ALL
                SELECT 'Casual' AS LogType, id, plateNumber, vehicleType, name, TimeIn, TimeOut, Rate, place, discountInfo
                FROM Casual_log 
                WHERE MONTH(TimeIn) = @selectedMonth AND YEAR(TimeIn) = @selectedYear
                ORDER BY TimeIn";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@selectedMonth", selectedMonth.Month);
                    cmd.Parameters.AddWithValue("@selectedYear", selectedMonth.Year);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }


        // Monthly report with discount
        public static DataTable GetParkingLogDataWithDiscountMonthly(DateTime selectedMonth)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                SELECT 'Flatrate' AS LogType, id, plateNumber, vehicleType, name, TimeIn, TimeOut, Rate, place, discountInfo
                FROM Flatrate_log 
                WHERE MONTH(TimeIn) = @selectedMonth AND YEAR(TimeIn) = @selectedYear AND discountInfo IS NOT NULL
                UNION ALL
                SELECT 'Casual' AS LogType, id, plateNumber, vehicleType, name, TimeIn, TimeOut, Rate, place, discountInfo
                FROM Casual_log 
                WHERE MONTH(TimeIn) = @selectedMonth AND YEAR(TimeIn) = @selectedYear AND discountInfo IS NOT NULL
                ORDER BY TimeIn";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@selectedMonth", selectedMonth.Month);
                    cmd.Parameters.AddWithValue("@selectedYear", selectedMonth.Year);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }


        //overstayonly
        public static DataTable GetParkingLogDataOverstayMonthly(DateTime selectedMonth)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                TimeSpan operationEndTime = new TimeSpan(21, 0, 0); // 9 PM

                string query = @"
                SELECT * FROM (
                    SELECT 'Flatrate' AS LogType, id, plateNumber, vehicleType, name, TimeIn, TimeOut, Rate, place, discountInfo
                    FROM Flatrate_log 
                    WHERE MONTH(TimeIn) = @selectedMonth AND YEAR(TimeIn) = @selectedYear
                    UNION ALL
                    SELECT 'Casual' AS LogType, id, plateNumber, vehicleType, name, TimeIn, TimeOut, Rate, place, discountInfo
                    FROM Casual_log 
                    WHERE MONTH(TimeIn) = @selectedMonth AND YEAR(TimeIn) = @selectedYear
                ) AS CombinedLogs
                WHERE CAST(TimeOut AS TIME) > @operationEndTime
                ORDER BY TimeIn";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@selectedMonth", selectedMonth.Month);
                    cmd.Parameters.AddWithValue("@selectedYear", selectedMonth.Year);
                    cmd.Parameters.AddWithValue("@operationEndTime", operationEndTime);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }




        public static (int totalVehicles, double totalRevenue) GetMonthlyTotals(DateTime selectedMonth)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
            SELECT 
                COUNT(*) AS TotalVehicles, 
                SUM(Rate) AS TotalRevenue
            FROM (
                SELECT Rate FROM Flatrate_log WHERE MONTH(TimeIn) = @selectedMonth AND YEAR(TimeIn) = @selectedYear
                UNION ALL
                SELECT Rate FROM Casual_log WHERE MONTH(TimeIn) = @selectedMonth AND YEAR(TimeIn) = @selectedYear
            ) AS Combined";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@selectedMonth", selectedMonth.Month);
                    cmd.Parameters.AddWithValue("@selectedYear", selectedMonth.Year);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int totalVehicles = reader.GetInt32(0);
                            double totalRevenue = reader.IsDBNull(1) ? 0.0 : (double)reader.GetDecimal(1);
                            return (totalVehicles, totalRevenue);
                        }
                    }
                }
            }
            return (0, 0.0);
        }
        //monthly

        //yearly
        public static DataTable GetParkingLogDataYearly(int year)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                SELECT 'Flatrate' AS LogType, id, plateNumber, vehicleType, name, TimeIn, TimeOut, Rate, place, discountInfo
                FROM Flatrate_log 
                WHERE YEAR(TimeIn) = @year
                UNION ALL
                SELECT 'Casual' AS LogType, id, plateNumber, vehicleType, name, TimeIn, TimeOut, Rate, place, discountInfo
                FROM Casual_log 
                WHERE YEAR(TimeIn) = @year
                ORDER BY TimeIn";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@year", year);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }


        // Yearly report with discount
        public static DataTable GetParkingLogDataWithDiscountYearly(int year)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                SELECT 'Flatrate' AS LogType, id, plateNumber, vehicleType, name, TimeIn, TimeOut, Rate, place, discountInfo
                FROM Flatrate_log 
                WHERE YEAR(TimeIn) = @year AND discountInfo IS NOT NULL
                UNION ALL
                SELECT 'Casual' AS LogType, id, plateNumber, vehicleType, name, TimeIn, TimeOut, Rate, place, discountInfo
                FROM Casual_log 
                WHERE YEAR(TimeIn) = @year AND discountInfo IS NOT NULL
                ORDER BY TimeIn";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@year", year);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        //overstay only
        public static DataTable GetParkingLogDataOverstayYearly(int year)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Define the operation end time as a TimeSpan
                TimeSpan operationEndTime = new TimeSpan(21, 0, 0); // 9 PM

                string query = @"
                SELECT * FROM (
                    SELECT 'Flatrate' AS LogType, id, plateNumber, vehicleType, name, TimeIn, TimeOut, Rate, place, discountInfo
                    FROM Flatrate_log 
                    WHERE YEAR(TimeIn) = @year
                    UNION ALL
                    SELECT 'Casual' AS LogType, id, plateNumber, vehicleType, name, TimeIn, TimeOut, Rate, place, discountInfo
                    FROM Casual_log 
                    WHERE YEAR(TimeIn) = @year
                ) AS CombinedLogs
                WHERE CAST(TimeOut AS TIME) > @operationEndTime
                ORDER BY TimeIn";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@operationEndTime", operationEndTime);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }





        // Method to calculate total vehicles and total revenue for a specific year
        public static (int totalVehicles, double totalRevenue) GetYearlyTotals(int year)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                SELECT 
                    COUNT(*) AS TotalVehicles, 
                    ISNULL(SUM(Rate), 0) AS TotalRevenue
                FROM (
                    SELECT Rate FROM Flatrate_log WHERE YEAR(TimeIn) = @year
                    UNION ALL
                    SELECT Rate FROM Casual_log WHERE YEAR(TimeIn) = @year
                ) AS Combined";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@year", year);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int totalVehicles = reader.GetInt32(0);
                            decimal totalRevenueDecimal = reader.GetDecimal(1);
                            double totalRevenue = (double)totalRevenueDecimal;
                            return (totalVehicles, totalRevenue);
                        }
                    }
                }
            }
            return (0, 0.0);
        }

        //yearly
        //--------------------------- REPORT GENERATION ---------------------------//


        public delegate void ProgressUpdateDelegate(int percentDone);


        //--------------------------- DATABASE BACKUP ---------------------------//
        internal static void BackupDatabase(string backupPath, ProgressUpdateDelegate progressUpdateCallback)
        {
            try
            {
                IsBackupOrRestoreInProgress = true; // Set the flag to true indicating backup is in progress.

                progressUpdateCallback?.Invoke(10); // Start progress

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    if (!IsDatabaseInMultiUserMode(conn))
                    {
                        throw new InvalidOperationException("Database is not in MULTI_USER mode.");
                    }

                    string query = $@"BACKUP DATABASE [Metro_Parking] TO DISK = @BackupPath WITH NOFORMAT, NOINIT, NAME = 'Full Backup of Metro_Parking', SKIP, NOREWIND, NOUNLOAD, STATS = 10";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@BackupPath", backupPath);
                        command.CommandTimeout = 0;
                        command.ExecuteNonQuery();
                        progressUpdateCallback?.Invoke(50); // Halfway after execution
                    }

                    if (!SetDatabaseToMultiUser(conn))
                    {
                        throw new InvalidOperationException("Failed to set the database back to MULTI_USER mode after backup.");
                    }
                }

                progressUpdateCallback?.Invoke(100); // End progress
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error during database backup", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred during the backup process", ex);
            }
            finally
            {
                IsBackupOrRestoreInProgress = false; // Set the flag to false indicating backup has completed.
            }
        }


        internal static void RestoreDatabase(string restorePath, ProgressUpdateDelegate progressUpdateCallback)
        {
            string masterConnectionString = connectionString.Replace("Metro_Parking", "master");
            SqlConnection conn = null; // Declare conn outside of the using block to widen its scope

            try
            {
                IsBackupOrRestoreInProgress = true; // Set the flag to true indicating restore is in progress.

                conn = new SqlConnection(masterConnectionString); // Initialize the connection
                conn.Open();
                progressUpdateCallback?.Invoke(10);

                var dbState = GetDatabaseState(conn);
                if (dbState != "ONLINE")
                {
                    throw new InvalidOperationException($"The database is not in a state that allows restore. Current state: {dbState}.");
                }

                ExecuteSqlCommand(conn, GetKillConnectionsQuery());
                progressUpdateCallback?.Invoke(30);

                ExecuteSqlCommand(conn, "ALTER DATABASE [Metro_Parking] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                progressUpdateCallback?.Invoke(50);

                string query = $@"RESTORE DATABASE [Metro_Parking] FROM DISK = @RestorePath WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10";
                ExecuteRestoreCommand(conn, query, restorePath);
                progressUpdateCallback?.Invoke(70);

                if (!SetDatabaseToMultiUser(conn))
                {
                    throw new InvalidOperationException("Failed to set the database to MULTI_USER mode after restore.");
                }
                progressUpdateCallback?.Invoke(90);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred during the restore process", ex);
            }
            finally
            {
                try
                {
                    // Here we check if conn is not null to avoid NullReferenceException
                    if (conn != null && !IsDatabaseInMultiUserMode(conn))
                    {
                        SetDatabaseToMultiUser(conn);
                    }
                }
                catch (Exception ex)
                {
                    // Handle the potential additional exception
                }
                finally
                {
                    // Here we also check if conn is not null before attempting to close it
                    if (conn?.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    IsBackupOrRestoreInProgress = false; // Set the flag to false indicating restore has completed.
                }
            }

            WaitForDatabaseToStabilize("Metro_Parking");
            progressUpdateCallback?.Invoke(100);
        }




        private static string GetDatabaseState(SqlConnection conn)
        {
            string stateQuery = "SELECT state_desc FROM sys.databases WHERE name = 'Metro_Parking'";
            using (SqlCommand cmd = new SqlCommand(stateQuery, conn))
            {
                return (string)cmd.ExecuteScalar();
            }
        }




        private static bool IsDatabaseRestoring(SqlConnection conn)
        {
            string stateQuery = "SELECT state_desc FROM sys.databases WHERE name = 'Metro_Parking'";
            using (SqlCommand cmd = new SqlCommand(stateQuery, conn))
            {
                string stateDesc = (string)cmd.ExecuteScalar();
                return stateDesc.Equals("RESTORING", StringComparison.OrdinalIgnoreCase);
            }
        }



        private static bool IsDatabaseInMultiUserMode(SqlConnection conn)
        {
            string checkQuery = "SELECT user_access_desc FROM sys.databases WHERE name = 'Metro_Parking'";
            using (SqlCommand cmd = new SqlCommand(checkQuery, conn))
            {
                string accessDesc = (string)cmd.ExecuteScalar();
                return accessDesc.Equals("MULTI_USER", StringComparison.OrdinalIgnoreCase);
            }
        }

        private static bool SetDatabaseToMultiUser(SqlConnection conn)
        {
            try
            {
                ExecuteSqlCommand(conn, "ALTER DATABASE [Metro_Parking] SET MULTI_USER");
                return true;
            }
            catch (Exception ex)
            {
                // Log the error or handle it as appropriate.
                // Consider alerting a system administrator or retrying the operation.
                return false;
            }
        }

        private static void WaitForDatabaseToStabilize(string databaseName)
        {
            bool isStable = false;
            int maxAttempts = 10; // Set a max number of attempts to avoid an infinite loop
            int attempt = 0;

            // A simple query to test the database connection and status.
            string testQuery = "SELECT 1"; // This should be a lightweight query

            while (!isStable && attempt < maxAttempts)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand command = new SqlCommand(testQuery, conn))
                        {
                            if ((int)command.ExecuteScalar() == 1)
                            {
                                // If we reach here, the database is up and responding to queries
                                if (IsDatabaseInMultiUserMode(conn))
                                {
                                    isStable = true;
                                    break; // Exit the loop if the database is in multi-user mode
                                }
                            }
                        }
                    }
                }
                catch (SqlException)
                {
                    // If there's an SQL error, the database might not be ready yet
                    // Log this exception if necessary
                }
                catch (Exception ex)
                {
                    // Handle other exceptions, possibly rethrowing them or logging them
                    // Log this exception if necessary
                    throw;
                }

                attempt++;
                // Wait for a bit before the next attempt
                // You can adjust the delay to suit your environment.
                System.Threading.Thread.Sleep(2000); // Wait for 2 seconds
            }

            if (!isStable)
            {
                throw new InvalidOperationException($"Unable to confirm that the database '{databaseName}' is stable after {maxAttempts} attempts.");
            }
        }



        private static string GetKillConnectionsQuery()
        {
            // Exclude the current session using AND session_id <> @@SPID
            return @"
            USE master;
            DECLARE @kill VARCHAR(8000) = '';  
            SELECT @kill = @kill + 'KILL ' + CONVERT(VARCHAR(5), session_id) + ';'
            FROM sys.dm_exec_sessions
            WHERE database_id  = DB_ID('Metro_Parking') AND session_id <> @@SPID;
            EXEC(@kill);
            ";
        }





        private static void ExecuteRestoreCommand(SqlConnection conn, string query, string restorePath)
        {
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@RestorePath", restorePath);
                command.CommandTimeout = 0; // Wait indefinitely for the restore operation to complete.
                command.ExecuteNonQuery();
            }
        }

        // Helper method to execute a SQL command without needing to duplicate code
        private static void ExecuteSqlCommand(SqlConnection conn, string query)
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }



        //--------------------------- DATABASE BACKUP ---------------------------//


        //--------------------------- ADMIN LOG ---------------------------//
        public DataTable GetAdminLogsByMonthAndYear(int year, int month)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM admin_log 
                             WHERE YEAR(adminTimeIN) = @year AND MONTH(adminTimeIN) = @month";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@month", month);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }


        public void InsertAdminLoginTime()
        {
            string sessionId = Guid.NewGuid().ToString(); // Generate a new GUID
            AppState.CurrentSessionId = sessionId; // Store in AppState

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO admin_log (adminTimeIN, sessionId) 
                         VALUES (GETDATE(), @sessionId)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sessionId", sessionId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }



        public void UpdateAdminLogoutTime(string sessionId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            UPDATE admin_log
            SET adminTimeOUT = GETDATE()
            WHERE sessionId = @sessionId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sessionId", sessionId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }




        public string GetAdminName(string adminUsername)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT adminFname, adminMname, adminLname FROM admin_info 
                         WHERE adminUser = @adminUser";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@adminUser", adminUsername);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string firstName = reader["adminFname"].ToString();
                            string middleName = reader["adminMname"].ToString();
                            string lastName = reader["adminLname"].ToString();

                            string formattedName = $"{lastName}, {firstName} {middleName.FirstOrDefault()}.";
                            return formattedName.Trim();
                        }
                    }
                }
            }
            return null;
        }

        public bool VerifyAndLogAdminLogin(string inputUsername, string inputPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT adminUser, adminPass FROM admin_info WHERE adminUser = @Username";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", inputUsername);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string correctPassword = reader["adminPass"].ToString();

                            if (inputPassword == correctPassword)
                            {
                                InsertAdminLoginTime(); // No need to pass adminName
                                return true; // Credentials are correct and time logged
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                }
                return false; // Invalid credentials or database error
            }
        }








        //--------------------------- ADMIN LOG ---------------------------//









        //----------TAPOS NA ATA huhuhuhuh-------------//
    }
}
