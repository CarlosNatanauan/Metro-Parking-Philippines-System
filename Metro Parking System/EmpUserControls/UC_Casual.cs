using Metro_Parking_System.AdmData;
using Metro_Parking_System.EmpData;
using Metro_Parking_System.Prompt;
using Metro_Parking_System.Prompts;
using Metro_Parking_System1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_Parking_System.UserControls
{
    public partial class UC_Casual : UserControl
    {
        private DateTime lastUpdated = DateTime.MinValue;
        public UC_Casual()
        {
            InitializeComponent();
            PaperSize receiptPaperSize = new PaperSize("Receipt", ConvertMillimetersToPixels(56), ConvertMillimetersToPixels(300));
            printDocument1.DefaultPageSettings.PaperSize = receiptPaperSize;
        }

        private void btInCasual_Click(object sender, EventArgs e)
        {
            DateTime timeIn = DateTime.Now;
            string plateNumber = tbplateNoCasual.Text;
            string name = tbNameCas.Text;

            if (cbVehicleTypeCas.SelectedItem == null)
            {
                MessageBox.Show("Please select a vehicle type.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string vehicleType = cbVehicleTypeCas.SelectedItem.ToString();

            if (!databaseCodes.InsertPlateNumberCasual(plateNumber, name, vehicleType, timeIn))
            {
                MessageBox.Show("Selected parking place is full", "Parking Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvCasual.DataSource = databaseCodes.GetAllPlateNumbersCasual();

            //fr refresh
            Refresher.Enabled = true;
            databaseCodes.UpdateRefreshTimestamp(DateTime.Now);
            ShowPrintPreview();
            ClearBoxes();
        }


        /// Updates the selected plate number.
        private void UpdatePlateNumber()
        {
            if (dgvCasual.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvCasual.SelectedRows[0].Index;
                int plateNumberColumnIndex = 0;
                string oldPlateNumber = dgvCasual.Rows[selectedRowIndex].Cells[plateNumberColumnIndex].Value.ToString();

                using (UpdatePlate inputForm = new UpdatePlate())
                {

                    inputForm.newPlateNumber = oldPlateNumber;

                    if (inputForm.ShowDialog() == DialogResult.OK)
                    {
                        string newPlateNumber = inputForm.newPlateNumber;

                        if (!string.IsNullOrEmpty(newPlateNumber) && !newPlateNumber.Equals(oldPlateNumber, StringComparison.InvariantCultureIgnoreCase))
                        {
                            databaseCodes.UpdatePlateNumberCasual(oldPlateNumber, newPlateNumber);
                            dgvCasual.Rows[selectedRowIndex].Cells[plateNumberColumnIndex].Value = newPlateNumber.ToUpper(CultureInfo.InvariantCulture);
                            MessageBox.Show("Plate Number updated successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btUpdate_Click(object sender, EventArgs e)
        {
            UpdatePlateNumber();
        }

        private void UC_Casual_Load(object sender, EventArgs e)
        {
            dgvCasual.DataSource = databaseCodes.GetAllPlateNumbersCasual();
            DisableControlsBasedOnJobDesc();//disable buttons depende sa role mo par

            dgvCasual.DataSource = databaseCodes.GetAllPlateNumbersCasual();
            foreach (DataGridViewColumn column in dgvCasual.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btbClearCasual_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        private void ClearBoxes() {
            tbplateNoCasual.Text = string.Empty;
            tbNameCas.Text = string.Empty;
            cbVehicleTypeCas.SelectedIndex = -1;
        }


        private void cbVehicleTypeCas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2ComboBox ctl = sender as Guna.UI2.WinForms.Guna2ComboBox;
            if (ctl.SelectedIndex == -1)
            {
                placeholderLabel.Visible = true;
            }
            else
            {
                placeholderLabel.Visible = false;
            }
        }


        private decimal cashEnteredReceipt;
        private decimal changeReceipt;
        private int idReceipt;

        private int regularRateReceipt = 0;
        private int overNightFeeReceipt = 0;
        private int lostTicketFeeReceipt = 0;
        private decimal vatableReceipt = 0;
        private decimal vatReceipt = 0;
        private decimal discountAmounts = 0;
        private int calculatedDiscountAmount = 0;


        private void btOutCasual_Click(object sender, EventArgs e)
        {
            if (dgvCasual.SelectedRows.Count > 0)
            {
                var databaseInstance = new databaseCodes();
                databaseInstance.FetchRates();

                int selectedRowIndex = dgvCasual.SelectedRows[0].Index;
                int idColumnIndex = 6;
                int id = Convert.ToInt32(dgvCasual.Rows[selectedRowIndex].Cells[idColumnIndex].Value);
                idReceipt = id;
                DataRow selectedRow = databaseCodes.GetCasualRecordById(id);

                if (selectedRow != null)
                {
                    string plateNumber = selectedRow["plateNumber"] != DBNull.Value ? selectedRow["plateNumber"].ToString() : string.Empty;
                    string selectedPlace = databaseCodes.GetPlaceForPlateNumberCasual(plateNumber);
                    string name = selectedRow["name"] != DBNull.Value ? selectedRow["name"].ToString() : string.Empty;
                    string vehicleType = selectedRow["vehicleType"] != DBNull.Value ? selectedRow["vehicleType"].ToString() : string.Empty;
                    DateTime timeIn = selectedRow["timeIn"] != DBNull.Value ? DateTime.Parse(selectedRow["timeIn"].ToString()) : DateTime.MinValue;
                    decimal rate = selectedRow["rate"] != DBNull.Value ? Convert.ToInt32(selectedRow["rate"]) : databaseCodes.RateCasTwoHours;



                    decimal tempRateCasual = databaseCodes.CalculateUpdatedRateCasual(plateNumber, false, false); // Default values assuming no ticket is lost and no discount is applied
                    using (EnterCash enterCashForm = new EnterCash())
                    {

                        enterCashForm.SetTemporaryRate(tempRateCasual); // Assuming you have a method to display the temporary rate on the form

                        enterCashForm.RateChanged += (isDiscountApplied, isTicketLost) =>
                        {
                            // Calculate rate with penalty (but no discount)
                            decimal tempRateCasualWithPenalty = databaseCodes.CalculateUpdatedRateCasual(plateNumber, isTicketLost, false);

                            // Recalculate the final rate (including any discounts)
                            decimal newTempRate = databaseCodes.CalculateUpdatedRateCasual(plateNumber, isTicketLost, isDiscountApplied);

                            // Calculate discount amount
                            discountAmounts = tempRateCasualWithPenalty - newTempRate;

                            enterCashForm.SetTemporaryRate(newTempRate); // Update the displayed rate
                        };

                        //MessageBox.Show($"Discount amount: {discountAmounts}");
                        DialogResult result = enterCashForm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            bool isTicketLost = enterCashForm.IsTicketLost;
                            bool isDiscountApplied = enterCashForm.IsDiscountApplied;
                            DateTime timeOut = DateTime.Now;

                            // At this point, consider refetching or recalculating the rate based on user choices.
                            rate = databaseCodes.CalculateUpdatedRateCasual(plateNumber, isTicketLost, isDiscountApplied);

                            
                            databaseCodes.InsertTimeOutForCasual(plateNumber, timeOut, isTicketLost, isDiscountApplied);
                            decimal cashEntered = enterCashForm.CashEntered;
                            cashEnteredReceipt = enterCashForm.CashEntered;
                            changeReceipt = cashEntered - rate;


                            //for receipt printing
                            Dictionary<string, string> receiptValues = GenerateReceipt(plateNumber, timeIn, timeOut, rate, cashEntered, enterCashForm.IsDiscountApplied, enterCashForm.IsTicketLost);

                            if (!decimal.TryParse(receiptValues["First Two Hours:"].Replace("P", "").Trim(), out decimal regularRateReceiptValue))
                            {
                                // Handle the error - the string was not in a valid decimal format.
                                regularRateReceiptValue = 0; // Default value or throw an exception
                            }
                            decimal regularRateReceipt = regularRateReceiptValue;

                            if (!decimal.TryParse(receiptValues["Over Night Fee:"].Replace("P", "").Trim(), out decimal overNightFeeReceiptValue))
                            {
                                // Handle the error
                                overNightFeeReceiptValue = 0; // Default value or throw an exception
                            }
                            decimal overNightFeeReceipt = overNightFeeReceiptValue;

                            if (!decimal.TryParse(receiptValues["Lost Ticket:"].Replace("P", "").Trim(), out decimal lostTicketFeeReceiptValue))
                            {
                                // Handle the error
                                lostTicketFeeReceiptValue = 0; // Default value or throw an exception
                            }
                            decimal lostTicketFeeReceipt = lostTicketFeeReceiptValue;

                            if (!decimal.TryParse(receiptValues["Vatable:"].Replace("P", "").Trim(), out decimal vatableReceiptValue))
                            {
                                // Handle the error
                                vatableReceiptValue = 0; // Default value or throw an exception
                            }
                            decimal vatableReceipt = vatableReceiptValue;

                            if (!decimal.TryParse(receiptValues["12% VAT:"].Replace("P", "").Trim(), out decimal vatReceiptValue))
                            {
                                // Handle the error
                                vatReceiptValue = 0; // Default value or throw an exception
                            }
                            decimal vatReceipt = vatReceiptValue;
                            this.receiptValues = GenerateReceipt(plateNumber, timeIn, timeOut, rate, cashEntered, enterCashForm.IsDiscountApplied, enterCashForm.IsTicketLost);


                            using (Receipt receiptForm = new Receipt(plateNumber, timeIn, timeOut, rate, cashEntered))
                            {
                                //receiptForm.ShowDialog();
                            }

                            if (enterCashForm.IsPaidButtonClicked)
                            {
                                string discountInfo = enterCashForm.DiscountInfo;
                                int idDeleted = databaseCodes.DeleteFromCasualRaw(plateNumber);
                                databaseCodes.InsertCasualLog(id, plateNumber, name, vehicleType, timeIn, timeOut, rate, selectedPlace, discountInfo);
                                dgvCasual.DataSource = databaseCodes.GetAllPlateNumbersCasual();
                                ShowPrintPreviewReceipt(id);//for printing
                                databaseCodes.IncrementPlaceValueCasual(selectedPlace);

                                Refresher.Enabled = true;
                                databaseCodes.UpdateRefreshTimestamp(DateTime.Now); 
                            }
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            // User cancelled the action
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Record not found for selected row.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Refresher.Enabled = true;
            databaseCodes.UpdateRefreshTimestamp(DateTime.Now);
            UpdateOccupiedAndAvailableLabels();

        }


        private void cbVehicleTypeCas_Leave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2ComboBox ctl = sender as Guna.UI2.WinForms.Guna2ComboBox;
            if (ctl.SelectedIndex == -1)
            {
                placeholderLabel.Visible = true;
            }
        }

        private void cbVehicleTypeCas_Enter(object sender, EventArgs e)
        {
            placeholderLabel.Visible = false;
        }


        /// Updates the occupied and available parking slot labels.
        private void UpdateOccupiedAndAvailableLabels()
        {
            databaseCodes dbCodes = new databaseCodes();
            ParkingPlace parkingPlace = dbCodes.GetParkingPlaceData();

            int totalAvailable = parkingPlace.mt1 + parkingPlace.mt2 + parkingPlace.mt3 +
                         parkingPlace.c1 + parkingPlace.c2 + parkingPlace.c3 +
                         parkingPlace.c4 + parkingPlace.c5 + parkingPlace.c6 +
                         parkingPlace.t1 + parkingPlace.t2;
            availableCasual.Text = totalAvailable.ToString();

            int totalOccupied = 120 - totalAvailable;
            occupiedCasual.Text = totalOccupied.ToString();
        }


        /// Event handler for search button click.
        /// Searches for a specific vehicle in the DataGridView based on its plate number.
        private void btSearchCasual_Click(object sender, EventArgs e)
        {
            string searchValue = tbPlateCasual.Text.Trim();

            DataTable dt = databaseCodes.GetAllPlateNumbersCasual();

            DataRow[] foundRows = dt.Select("PlateNumber = '" + searchValue + "'");

            if (foundRows.Length > 0)
            {
                dgvCasual.ClearSelection();
                dgvCasual.CurrentCell = dgvCasual.Rows[dt.Rows.IndexOf(foundRows[0])].Cells[0];
                dgvCasual.Rows[dt.Rows.IndexOf(foundRows[0])].Selected = true;
            }
            else
            {
                MessageBox.Show("The PlateNumber cannot be found", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateOccupiedAndAvailableLabels();
        }


        private void dgvCasual_DataSourceChanged(object sender, EventArgs e)
        {
            UpdateOccupiedAndAvailableLabels();
        }

        private void Refresher_Tick(object sender, EventArgs e)
        {
            DateTime? timestampNullable = databaseCodes.GetRefreshTimestamp();

            // Check if the timestamp is not null before proceeding.
            if (timestampNullable.HasValue)
            {
                DateTime timestamp = timestampNullable.Value;
                if (timestamp > lastUpdated)
                {
                    dgvCasual.Invoke(new Action(() => dgvCasual.DataSource = databaseCodes.GetAllPlateNumbersCasual()));
                    UpdateOccupiedAndAvailableLabels();
                    lastUpdated = timestamp;
                }
            }
            else
            {
                // Handle the situation when timestamp is null, which might mean a backup is in progress.
                // For example, you could log this, show a message to the user, or simply do nothing.
            }
        }


        private void PrintReceipt()
        {
            printDocument1.PrinterSettings.PrinterName = "XP-58IID";
            printDocument1.Print();
        }


        private void ShowPrintPreview()
        {
            printPreviewDialog1.ShowDialog();
        }

        private int ConvertMillimetersToPixels(float millimeters)
        {
            return (int)(millimeters * 3.937);
        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            // Fetching Ticket No from database
            DataTable dt = databaseCodes.GetAllPlateNumbersCasual();


            // Adjusting the font sizes
            Font headerFont = new Font("Courier New", 7, FontStyle.Bold); // Header
            Font dateFont = new Font("Courier New", 7, FontStyle.Bold); // For Date
            Font detailsFont = new Font("Courier New", 8); // Vehicle details
            Font footerFont = new Font("Courier New", 5, FontStyle.Italic); // Footer
            Font addressFont = new Font("Courier New", 4, FontStyle.Regular); // Adjusted font size for the Address
            Font mallFont = new Font("Courier New", 4.2f, FontStyle.Bold); // Bold Font for "TARGET MALL"

            float totalPaperWidthPixels = ConvertMillimetersToPixels(56);
            float printWidthPixels = ConvertMillimetersToPixels(48);
            float leftMargin = (totalPaperWidthPixels - printWidthPixels) / 2;
            float paperWidth = leftMargin + printWidthPixels;  // This will be the right boundary
            float yPos = 10;

            //header


            Bitmap metroParkingImage;
            try
            {
                var assembly = GetType().Assembly;
                string resourceNamespace = "Metro_Parking_System.Images.metroparking.png";

                using (Stream stream = assembly.GetManifestResourceStream(resourceNamespace))
                {
                    if (stream == null)
                    {
                        MessageBox.Show("Error loading image: Resource not found.");
                        return;
                    }

                    metroParkingImage = new Bitmap(stream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
                return;
            }






            // Calculate the combined height of "METRO PARKING" and "Management (Phils.) Inc."
            SizeF metroParkingSize = graphics.MeasureString("METRO PARKING", headerFont);
            Font managementFont = new Font("Courier New", 4, FontStyle.Regular);
            SizeF managementSize = graphics.MeasureString("Management (Phils.) Inc", managementFont);

            float imageHeight = metroParkingSize.Height + managementSize.Height;
            float aspectRatio = (float)metroParkingImage.Width / metroParkingImage.Height;
            float imageWidth = aspectRatio * imageHeight;
            RectangleF destRect = new RectangleF(leftMargin, yPos, imageWidth, imageHeight);

            graphics.DrawImage(metroParkingImage, destRect);

            float textXPos = leftMargin + imageWidth + 5;
            float managementYPos = yPos + metroParkingSize.Height;
            graphics.DrawString("METRO PARKING", headerFont, Brushes.Black, textXPos, yPos);
            graphics.DrawString("Management (Phils.) Inc", managementFont, Brushes.Black, textXPos, managementYPos);

            const float adjustment = 20;

            // Aligning "PARKING TICKET" to the top of "METRO PARKING"
            Font parkingTicketFont = new Font("Courier New", 4, FontStyle.Regular);
            float parkingTicketXPos = textXPos + Math.Max(metroParkingSize.Width, managementSize.Width) + 5 + adjustment;
            float parkingTicketYPos = yPos;
            graphics.DrawString("TICKET NUMBER", parkingTicketFont, Brushes.Black, parkingTicketXPos, parkingTicketYPos);

            // For the ticket number to be bigger, create a font object with a larger size.
            Font ticketNoFont = new Font("Courier New", 8, FontStyle.Regular);

            // Get the ticket number
            int ticketNo = (int)dt.Rows[dt.Rows.Count - 1]["id"];
            string ticketNoStr = ticketNo.ToString();

            // Calculate a small space between "PARKING TICKET" and the ticket number
            float smallSpaceBetween = 2.0f; // adjust as necessary

            // Calculating ticketNoYPos to be closer to parkingTicketYPos
            float ticketNoYPos = parkingTicketYPos + parkingTicketFont.GetHeight() + smallSpaceBetween;
            float ticketNoXPos = parkingTicketXPos;

            graphics.DrawString(ticketNoStr, ticketNoFont, Brushes.Red, ticketNoXPos, ticketNoYPos);

            // Adjust yPos for next drawings.
            float someSpace = 5;
            yPos = ticketNoYPos + ticketNoFont.GetHeight() + someSpace;



            //address
            string[] addressLines =
            {
            "Target Basement Area, Santa Rosa Commercial Complex,",
            "Balibago Sta. Rosa City 4026 Laguna Philippines",
            "VAT Reg. TIN: 005-620-115-00084"
            };

            // Center-align and print "TARGET MALL" with bold font
            string mallLine = "TARGET MALL";
            SizeF mallSize = graphics.MeasureString(mallLine, mallFont);
            float mallOffset = 8.5f; // Adjust this value as needed
            graphics.DrawString(mallLine, mallFont, Brushes.Black, (paperWidth - mallSize.Width) / 2 + mallOffset, yPos);
            yPos += mallSize.Height; // Move yPos down for the next line



            // Center-align and print the remaining address lines with regular font
            foreach (var addressLine in addressLines)
            {
                SizeF addressSize = graphics.MeasureString(addressLine, addressFont);
                float addressOffset = 8.5f; // Adjust this value as needed
                graphics.DrawString(addressLine, addressFont, Brushes.Black, (paperWidth - addressSize.Width) / 2 + addressOffset, yPos);

                yPos += addressSize.Height; // Move yPos down for the next line
            }

            yPos += 7; // Add extra space after the address


            // Print Date (Left) and Day (Right)
            string currentDate = DateTime.Now.ToString("MMM dd, yyyy");
            string currentDay = DateTime.Now.ToString("dddd");
            SizeF daySize = graphics.MeasureString(currentDay, dateFont);
            graphics.DrawString(currentDate, dateFont, Brushes.Black, leftMargin, yPos);
            graphics.DrawString(currentDay, dateFont, Brushes.Black, paperWidth - daySize.Width, yPos);
            yPos += daySize.Height + 5;

            //time in
            float yPosAfterDay = yPos - 5; // Adjust this to create the space between day and time in

            // Print TIME IN
            Font boldFont = new Font("Courier New", 7, FontStyle.Bold); // Adjust the size and style as per your needs
            string timeInLabel = "TIME IN:";
            SizeF timeInLabelSize = graphics.MeasureString(timeInLabel, boldFont);
            graphics.DrawString(timeInLabel, boldFont, Brushes.Black, leftMargin, yPosAfterDay);

            string timeInValue = dt.Rows[dt.Rows.Count - 1]["TimeIn"].ToString(); // Fetching the value from database
            SizeF timeInValueSize = graphics.MeasureString(timeInValue, boldFont);
            graphics.DrawString(timeInValue, boldFont, Brushes.Black, paperWidth - timeInValueSize.Width, yPosAfterDay);

            yPos = yPosAfterDay + timeInValueSize.Height; // Adjusting yPos for next drawings, 5 is for space below the TIME IN

            // Line separator
            Pen dashedPen = new Pen(Brushes.Black);
            dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            // Dashed Line separator
            graphics.DrawLine(dashedPen, leftMargin, yPos, paperWidth, yPos);
            yPos += 5;

            // Don't forget to dispose of the pen object once done
            dashedPen.Dispose();



            // Print the parking details
            string[] labels = { "Vehicle Type", "Plate No.", "Driver's Name", "Paking Place" };
            string placeFromDatabase = databaseCodes.GetPlaceForPlateNumberCasual(tbplateNoCasual.Text.Trim()).ToUpper();

            string[] values =
            {
            cbVehicleTypeCas.SelectedItem.ToString(),
            tbplateNoCasual.Text.ToUpper(),
            tbNameCas.Text,
            placeFromDatabase
            };

            // When you are printing Parking Details...
            for (int i = 0; i < labels.Length; i++)
            {
                Font detailFont = new Font("Courier New", 8, FontStyle.Regular); // Adjust size as necessary
                float valueStartPos = paperWidth - graphics.MeasureString(values[i], detailFont).Width;

                graphics.DrawString(labels[i], detailFont, Brushes.Black, leftMargin, yPos);
                graphics.DrawString(values[i], detailFont, Brushes.Black, valueStartPos, yPos);
                yPos += 15; // Adjust the line height as necessary
            }



            // Line separator
            Pen dashedPen1 = new Pen(Brushes.Black);
            dashedPen1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            // Dashed Line separator
            graphics.DrawLine(dashedPen1, leftMargin, yPos, paperWidth, yPos);
            yPos += 5;

            // Don't forget to dispose of the pen object once done
            dashedPen1.Dispose();



            string operationHours = "    OPERATION HOURS";
            string operationDetails = "    Monday to Sunday 08:00 AM - 09:00 PM";

            Font operationHoursFont = new Font("Courier New", 6, FontStyle.Bold); // Font size 6 for OPERATION HOURS
            Font operationDetailsFont = new Font("Courier New", 5, FontStyle.Regular); // Font size 4 for operation details

            // Draw OPERATION HOURS
            SizeF operationHoursSize = graphics.MeasureString(operationHours, operationHoursFont);
            graphics.DrawString(operationHours, operationHoursFont, Brushes.Black, (paperWidth - operationHoursSize.Width) / 2, yPos);
            yPos += operationHoursSize.Height; // Add height for the next line

            // Draw operation details
            SizeF operationDetailsSize = graphics.MeasureString(operationDetails, operationDetailsFont);
            graphics.DrawString(operationDetails, operationDetailsFont, Brushes.Black, (paperWidth - operationDetailsSize.Width) / 2, yPos);
            yPos += operationDetailsSize.Height + 5; // Adding some space before the footer


            //disclaimer
            string keepTicket = "    PLEASE KEEP THIS TICKET";
            Font keepTicketFont = new Font("Courier New", 5, FontStyle.Bold); // You might want to adjust the size

            // Draw PLEASE KEEP THIS TICKET
            SizeF keepTicketSize = graphics.MeasureString(keepTicket, keepTicketFont);
            graphics.DrawString(keepTicket, keepTicketFont, Brushes.Black, (paperWidth - keepTicketSize.Width) / 2, yPos);
            yPos += keepTicketSize.Height + 1; // Add height for the next line

            Font disclaimerFont = new Font("Courier New", 3.5f, FontStyle.Regular); // Font size 3.5 for the disclaimer

            // You can split the disclaimer string manually or programmatically based on your paper width
            string[] disclaimerStrings = {
            "    This ticket MUST be presented to cashier upon leaving the",
            "    parking premises. Charges are for the use of Parking Space",
            "    only. The Management does not assume responsibility for any",
            "    loss and damage to the car and its content through fire,",
            "    theft, collision or other fortuitous events."
            };

            // Draw the disclaimer texts
            foreach (var disclaimerString in disclaimerStrings)
            {
                SizeF strSize = graphics.MeasureString(disclaimerString, disclaimerFont);
                float startX = (paperWidth - strSize.Width) / 2; // Center align the text
                graphics.DrawString(disclaimerString, disclaimerFont, Brushes.Black, startX, yPos);
                yPos += strSize.Height; // Add height for the next line
            }

            yPos += 5; // Adding some space after the disclaimer

            string finalNotice = "    PLEASE PARK AT YOUR OWN RISK/PLS.LOCK YOUR CAR";
            Font finalNoticeFont = new Font("Courier New", 4.5f, FontStyle.Bold); // Font size 5 for the final notice

            // Draw the final notice text
            // Draw the final notice text
            SizeF finalNoticeSize = graphics.MeasureString(finalNotice, finalNoticeFont);
            float finalNoticeStartX = (paperWidth - finalNoticeSize.Width) / 2; // Center align the text
            graphics.DrawString(finalNotice, finalNoticeFont, Brushes.Black, finalNoticeStartX, yPos);
            yPos += finalNoticeSize.Height + 5; // Add height for the next line and some space after the final notice


            // Clean up
            headerFont.Dispose();
            detailsFont.Dispose();
            footerFont.Dispose();
        }

        private void btSearchCasual_Click_1(object sender, EventArgs e)
        {
            string searchPlateValue = tbPlateCasual.Text.Trim();
            string searchIdValue = tbIdCasual.Text.Trim();

            DataTable dt = databaseCodes.GetAllPlateNumbersCasual();
            DataRow[] foundRows = null;

            // Check if user entered something in either text box.
            if (!string.IsNullOrEmpty(searchPlateValue))
            {
                foundRows = dt.Select("PlateNumber = '" + searchPlateValue + "'");
            }
            else if (!string.IsNullOrEmpty(searchIdValue))
            {
                foundRows = dt.Select("id = '" + searchIdValue + "'");
            }
            else
            {
                MessageBox.Show("Please enter either a PlateNumber or an ID.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (foundRows != null && foundRows.Length > 0)
            {
                dgvCasual.ClearSelection();
                dgvCasual.CurrentCell = dgvCasual.Rows[dt.Rows.IndexOf(foundRows[0])].Cells[0];
                dgvCasual.Rows[dt.Rows.IndexOf(foundRows[0])].Selected = true;
            }
            else
            {
                MessageBox.Show("The PlateNumber or ID cannot be found", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tbPlateCasual.Text = string.Empty;
            tbIdCasual.Text = string.Empty;
        }


        private void DisableControlsBasedOnJobDesc()
        {
            Employee employee = databaseCodes.GetEmployeeById(mainForm.LoggedInEmployeeId);
            if (employee == null) return; // handle null case as appropriate

            switch (employee.jobDesc)
            {
                case "Exit Lead":
                    placeholderLabel.BackColor = Color.FromArgb(226, 226, 226);
                    placeholderLabel.ForeColor = Color.FromArgb(139, 146, 146);
                    tbplateNoCasual.Enabled = false;
                    cbVehicleTypeCas.Enabled = false;
                    tbNameCas.Enabled = false;
                    btbClearCasual.Enabled = false;
                    btInCasual.Enabled = false;
                    break;

                case "Entry Lead":
                    tbPlateCasual.Enabled = false;
                    tbIdCasual.Enabled = false;
                    btSearchCasual.Enabled = false;
                    btOutCasual.Enabled = false;
                    break;
            }
        }



        private void ShowPrintPreviewReceipt(int id)
        {
            printPreviewDialog2.Tag = id;  // Store the id in the Tag property for later retrieval
            printPreviewDialog2.ShowDialog();
        }


        private Dictionary<string, string> receiptValues;
        private Dictionary<string, string> GenerateReceipt(string plateNumber, DateTime timeIn, DateTime timeOut, decimal rate, decimal cashEntered, bool isDiscountApplied, bool isTicketLost)
        {
            var (rate_cas_two_hours, others_pen_loss_tix, others_pen_over_stay, others_dis_pwdsen) = databaseCodes.GetRatesAndPenaltiesCasual();

            TimeSpan duration = timeOut - timeIn;
            decimal regularRate = 0;
            decimal suchours = 0;
            if (duration.TotalMinutes > 10)
            {
                regularRate = rate_cas_two_hours;  // Set to rate_cas_two_hours if duration exceeds 10 minutes
                suchours = databaseCodes.RateCasSucHours;
            }

            DateTime closeTime = new DateTime(timeIn.Year, timeIn.Month, timeIn.Day, 21, 0, 0);
            decimal overNightFee = (timeOut > closeTime) ? others_pen_over_stay : 0;
            decimal lostTicketFee = isTicketLost ? others_pen_loss_tix : 0;

            decimal vatRate = 0.12m;
            decimal vatable = rate / (1 + vatRate);
            decimal vat = rate - vatable;
            decimal change = cashEntered - rate;
            Employee employee = databaseCodes.GetEmployeeById(mainForm.LoggedInEmployeeId);
            string issuerName = string.IsNullOrEmpty(employee.empMiddleName)
                ? $"{employee.empFirstName} {employee.empLastName}"
                : $"{employee.empFirstName} {employee.empMiddleName} {employee.empLastName}";

            return new Dictionary<string, string>
            {
                { "First Two Hours:", $"P{regularRate.ToString("0.00")}" },
                { "Succeeding Hours:", $"P{suchours.ToString("0.00")}" },
                { "Over Night Fee:", $"P{overNightFee.ToString("0.00")}" },
                { "Lost Ticket:", $"P{lostTicketFee.ToString("0.00")}" },
                { "Discount:", $"P{discountAmounts.ToString("0.00")}" },
                { "Vatable:", $"P{Math.Round(vatable, 2).ToString("0.00")}" },
                { "12% VAT:", $"P{Math.Round(vat, 2).ToString("0.00")}" },
                { "Total Amount:", $"P{rate.ToString("0.00")}" },
                { "Tendered Amount:", $"P{Math.Round(cashEntered, 2).ToString("0.00")}" },
                { "Change:", $"P{Math.Round(change, 2).ToString("0.00")}" },
                { "Issuer:", issuerName }
            };

        }









        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            // Fetching Ticket No from database
            DataTable dt = databaseCodes.GetAllPlateNumbersCasual();

            // Adjusting the font sizes
            Font headerFont = new Font("Courier New", 7, FontStyle.Bold); // Header
            Font dateFont = new Font("Courier New", 7, FontStyle.Bold); // For Date
            Font detailsFont = new Font("Courier New", 8); // Vehicle details
            Font footerFont = new Font("Courier New", 5, FontStyle.Italic); // Footer
            Font addressFont = new Font("Courier New", 4, FontStyle.Regular); // Adjusted font size for the Address
            Font mallFont = new Font("Courier New", 4.2f, FontStyle.Bold); // Bold Font for "TARGET MALL"

            float totalPaperWidthPixels = ConvertMillimetersToPixels(56);
            float printWidthPixels = ConvertMillimetersToPixels(48);
            float leftMargin = (totalPaperWidthPixels - printWidthPixels) / 2;
            float paperWidth = leftMargin + printWidthPixels;  // This will be the right boundary
            float yPos = 10;

            //header
            Bitmap metroParkingImage;
            try
            {
                var assembly = GetType().Assembly;
                string resourceNamespace = "Metro_Parking_System.Images.metroparking.png";

                using (Stream stream = assembly.GetManifestResourceStream(resourceNamespace))
                {
                    if (stream == null)
                    {
                        MessageBox.Show("Error loading image: Resource not found.");
                        return;
                    }

                    metroParkingImage = new Bitmap(stream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
                return;
            }

            // Calculate the combined height of "METRO PARKING" and "Management (Phils.) Inc."
            SizeF metroParkingSize = graphics.MeasureString("METRO PARKING", headerFont);
            Font managementFont = new Font("Courier New", 4, FontStyle.Regular);
            SizeF managementSize = graphics.MeasureString("Management (Phils.) Inc", managementFont);

            float imageHeight = metroParkingSize.Height + managementSize.Height;
            float aspectRatio = (float)metroParkingImage.Width / metroParkingImage.Height;
            float imageWidth = aspectRatio * imageHeight;
            RectangleF destRect = new RectangleF(leftMargin, yPos, imageWidth, imageHeight);

            graphics.DrawImage(metroParkingImage, destRect);

            float textXPos = leftMargin + imageWidth + 5;
            float managementYPos = yPos + metroParkingSize.Height;
            graphics.DrawString("METRO PARKING", headerFont, Brushes.Black, textXPos, yPos);
            graphics.DrawString("Management (Phils.) Inc", managementFont, Brushes.Black, textXPos, managementYPos);

            const float adjustment = 20;

            // Aligning "PARKING TICKET" to the top of "METRO PARKING"
            Font parkingTicketFont = new Font("Courier New", 4, FontStyle.Regular);
            float parkingTicketXPos = textXPos + Math.Max(metroParkingSize.Width, managementSize.Width) + 5 + adjustment;
            float parkingTicketYPos = yPos;
            graphics.DrawString("RECEIPT NUMBER", parkingTicketFont, Brushes.Black, parkingTicketXPos, parkingTicketYPos);

            // For the ticket number to be bigger, create a font object with a larger size.
            Font ticketNoFont = new Font("Courier New", 8, FontStyle.Regular);

            // Get the receipt number
            //int ticketNo = (int)dt.Rows[dt.Rows.Count - 1]["id"];
            string ticketNoStr = idReceipt.ToString();

            // Calculate a small space between "PARKING TICKET" and the ticket number
            float smallSpaceBetween = 2.0f; // adjust as necessary

            // Calculating ticketNoYPos to be closer to parkingTicketYPos
            float ticketNoYPos = parkingTicketYPos + parkingTicketFont.GetHeight() + smallSpaceBetween;
            float ticketNoXPos = parkingTicketXPos;

            graphics.DrawString(ticketNoStr, ticketNoFont, Brushes.Red, ticketNoXPos, ticketNoYPos);

            // Adjust yPos for next drawings.
            float someSpace = 5;
            yPos = ticketNoYPos + ticketNoFont.GetHeight() + someSpace;


            //address
            string[] addressLines =
            {
            "Target Basement Area, Santa Rosa Commercial Complex,",
            "Balibago Sta. Rosa City 4026 Laguna Philippines",
            "VAT Reg. TIN: 005-620-115-00084"
            };

            // Center-align and print "TARGET MALL" with bold font
            string mallLine = "TARGET MALL";
            SizeF mallSize = graphics.MeasureString(mallLine, mallFont);
            float mallOffset = 8.5f; // Adjust this value as needed
            graphics.DrawString(mallLine, mallFont, Brushes.Black, (paperWidth - mallSize.Width) / 2 + mallOffset, yPos);
            yPos += mallSize.Height; // Move yPos down for the next line

            // Center-align and print the remaining address lines with regular font
            foreach (var addressLine in addressLines)
            {
                SizeF addressSize = graphics.MeasureString(addressLine, addressFont);
                float addressOffset = 8.5f; // Adjust this value as needed
                graphics.DrawString(addressLine, addressFont, Brushes.Black, (paperWidth - addressSize.Width) / 2 + addressOffset, yPos);

                yPos += addressSize.Height; // Move yPos down for the next line
            }
            yPos += 7; // Add extra space after the address


            Font boldFont = new Font("Courier New", 6, FontStyle.Regular); // Define this once at the top

            if (printPreviewDialog2.Tag is int id)
            {
                DataRow row = databaseCodes.GetCasualRecordByIdLog(id);

                if (row != null)
                {
                    // Extract data from the row
                    DateTime timeIn = (DateTime)row["TimeIn"];
                    DateTime timeOut = (DateTime)row["TimeOut"];
                    decimal rate = (decimal)row["rate"];

                    // Print DATE TIME IN
                    string dateTimeInLabel = "DATE TIME IN";
                    string dateTimeInValue = timeIn.ToString("MM/dd/yyyy HH:mm:ss");
                    SizeF dateTimeInLabelSize = graphics.MeasureString(dateTimeInLabel, boldFont);
                    SizeF dateTimeInValueSize = graphics.MeasureString(dateTimeInValue, boldFont);

                    graphics.DrawString(dateTimeInLabel, boldFont, Brushes.Black, leftMargin, yPos);
                    graphics.DrawString(dateTimeInValue, boldFont, Brushes.Black, paperWidth - dateTimeInValueSize.Width, yPos);
                    yPos += dateTimeInLabelSize.Height + 2;


                    // Print DATE TIME OUT
                    string dateTimeOutLabel = "DATE TIME OUT";
                    string dateTimeOutValue = timeOut.ToString("MM/dd/yyyy HH:mm:ss");
                    SizeF dateTimeOutLabelSize = graphics.MeasureString(dateTimeOutLabel, boldFont);
                    SizeF dateTimeOutValueSize = graphics.MeasureString(dateTimeOutValue, boldFont);

                    graphics.DrawString(dateTimeOutLabel, boldFont, Brushes.Black, leftMargin, yPos);
                    graphics.DrawString(dateTimeOutValue, boldFont, Brushes.Black, paperWidth - dateTimeOutValueSize.Width, yPos);
                    yPos += dateTimeOutLabelSize.Height + 2;

                    // Calculate and Print Duration
                    TimeSpan duration = timeOut - timeIn;
                    string durationValue;

                    if (duration.TotalDays >= 1)
                    {
                        int days = (int)duration.TotalDays;
                        int hours = duration.Hours;
                        int minutes = duration.Minutes;
                        int seconds = duration.Seconds;

                        durationValue = string.Format("{0}d {1}hr {2}mns & {3}scs", days, hours, minutes, seconds);
                    }
                    else
                    {
                        durationValue = string.Format("{0}hr {1}mns & {2}scs", duration.Hours, duration.Minutes, duration.Seconds);
                    }

                    string durationLabel = "Duration";
                    SizeF durationLabelSize = graphics.MeasureString(durationLabel, boldFont);
                    SizeF durationValueSize = graphics.MeasureString(durationValue, boldFont);

                    graphics.DrawString(durationLabel, boldFont, Brushes.Black, leftMargin, yPos);
                    graphics.DrawString(durationValue, boldFont, Brushes.Black, paperWidth - durationValueSize.Width, yPos);
                    yPos += durationLabelSize.Height + 2;

                    // Line separator
                    Pen dashedPen0 = new Pen(Brushes.Black);
                    dashedPen0.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                    // Dashed Line separator
                    graphics.DrawLine(dashedPen0, leftMargin, yPos, paperWidth, yPos);
                    yPos += 3;

                    string[] labels = {
                        "First Two Hours:",
                        "Succeeding Hours:",
                        "Over Night Fee:",
                        "Lost Ticket:",
                        "Discount:",
                        "Vatable:",
                        "12% VAT:",
                        "Total Amount:",
                        "Tendered Amount:",
                        "Change:",
                        "Issuer:"
                    };

                    string[] values = labels.Select(l => receiptValues[l]).ToArray();

                    for (int i = 0; i < labels.Length; i++)
                    {
                        SizeF labelSize = graphics.MeasureString(labels[i], boldFont);
                        SizeF valueSize = graphics.MeasureString(values[i], boldFont);

                        graphics.DrawString(labels[i], boldFont, Brushes.Black, leftMargin, yPos);
                        graphics.DrawString(values[i], boldFont, Brushes.Black, paperWidth - valueSize.Width, yPos);

                        yPos += labelSize.Height + 3;
                    }

                    // Dashed Line separator
                    graphics.DrawLine(dashedPen0, leftMargin, yPos, paperWidth, yPos);
                    yPos += 3;


                    string[] labels1 = { "Vehicle Type", "Plate No.", "Driver's Name", "Parking Place" };
                    string[] values1 =
                    {
                        row["vehicleType"].ToString(),
                        row["plateNumber"].ToString().ToUpper(),
                        CultureInfo.CurrentCulture.TextInfo.ToTitleCase(row["name"].ToString().ToLower()),
                        row["place"].ToString().ToUpper()
                    };

                    for (int i = 0; i < labels1.Length; i++)
                    {
                        Font detailFont = new Font("Courier New", 6, FontStyle.Regular);
                        float valueStartPos = paperWidth - graphics.MeasureString(values1[i], detailFont).Width;

                        graphics.DrawString(labels1[i], detailFont, Brushes.Black, leftMargin, yPos);
                        graphics.DrawString(values1[i], detailFont, Brushes.Black, valueStartPos, yPos);
                        yPos += 11; // Adjust the line height as necessary
                    }

                }
            }


            // Line separator
            Pen dashedPen1 = new Pen(Brushes.Black);
            dashedPen1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            // Dashed Line separator
            graphics.DrawLine(dashedPen1, leftMargin, yPos, paperWidth, yPos);
            yPos += 5;

            // Don't forget to dispose of the pen object once done
            dashedPen1.Dispose();




            Font receiptDisclaimerFont = new Font("Courier New", 4.5f, FontStyle.Bold);

            // Split the disclaimer into two lines
            string[] receiptDisclaimers = {
                "    This will serve as your official receipt,",
                "    Valid for 5 years from the issuance date."
            };

            // Draw the disclaimer texts
            foreach (var disclaimer in receiptDisclaimers)
            {
                // Center align each line
                SizeF strSize = graphics.MeasureString(disclaimer, receiptDisclaimerFont);
                float startX = (paperWidth - strSize.Width) / 2;

                graphics.DrawString(disclaimer, receiptDisclaimerFont, Brushes.Black, startX, yPos);
                yPos += strSize.Height; // Adjust for the next line
            }


            // Create a font for the disclaimer text
            Font disclaimerFont = new Font("Courier New", 4.5f, FontStyle.Regular);

            string disclaimerText = "Printer's Accreditation:049MP20190000000014\nAccreditation Date: 18-Jan-2019 \nExpiry Date: 17-Jan-2024\nBIR Authority to Print:057AU20220000012812\nDate of ATP: 11-15-2022";

            // Split the disclaimer text into lines
            string[] disclaimerLines = disclaimerText.Split('\n');

            // Draw each line of the disclaimer text
            foreach (var line in disclaimerLines)
            {
                // Split the line into label and value by the colon
                string[] parts = line.Split(':');
                string label = parts[0];
                string value = parts[1];

                // Measure the size of the label and value
                SizeF labelSize = graphics.MeasureString(label, disclaimerFont);
                SizeF valueSize = graphics.MeasureString(value, disclaimerFont);

                // Draw the label on the left and the value on the right
                graphics.DrawString(label, disclaimerFont, Brushes.Black, leftMargin, yPos);
                graphics.DrawString(value, disclaimerFont, Brushes.Black, paperWidth - valueSize.Width, yPos);

                // Add height for the next line
                yPos += labelSize.Height;
            }

            // Add some space after the text
            yPos += 2;


            string finalNotice = "    THANK YOU FOR CHOOSING US, COME AGAIN!";
            Font finalNoticeFont = new Font("Courier New", 4.5f, FontStyle.Bold); // Font size 5 for the final notice

            // Draw the final notice text
            // Draw the final notice text
            SizeF finalNoticeSize = graphics.MeasureString(finalNotice, finalNoticeFont);
            float finalNoticeStartX = (paperWidth - finalNoticeSize.Width) / 2; // Center align the text
            graphics.DrawString(finalNotice, finalNoticeFont, Brushes.Black, finalNoticeStartX, yPos);
            yPos += finalNoticeSize.Height + 5; // Add height for the next line and some space after the final notice


            // Clean up
            headerFont.Dispose();
            detailsFont.Dispose();
            footerFont.Dispose();
        }

        private void printPreviewDialog2_Load(object sender, EventArgs e)
        {

        }
    }
}
