using Metro_Parking_System1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_Parking_System.AdmUserControls.Report_Generation.Detailed_Report_Buttons
{
    public partial class UC_Monthly_detailed : UserControl
    {
        private DataTable _dataToPrint;
        private int _rowIndex;
        private bool _printSecondColumn;
        private int _pageIndex = 1;

        private enum ReportType
        {
            Regular,
            WithDiscount,
            OverStay
        }

        private ReportType _currentReportType = ReportType.Regular;

        public UC_Monthly_detailed()
        {
            InitializeComponent();
            dtpMonthly.Format = DateTimePickerFormat.Custom;
            this.dtpMonthly.Value = DateTime.Now;
            dtpMonthly.CustomFormat = "MMMM, yyyy";
            btViewReport.Enabled = false;
            setStatus();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Margin and layout setup
            int topPadding = 10;
            int initialTopMargin = 90 + topPadding;
            int topMargin = initialTopMargin;
            int rowHeight = 20;
            int[] columnWidths = { 30, 60, 90, 70, 70, 60, 90, 100, 70, 120 }; // Example widths
            int leftMargin = 40; // Start printing from the left margin of the page

            //string[] headers = { "Ticket No.", "Plate No", "Time In", "Time Out", "Amt. Paid" };

            int pageCenter = e.PageBounds.Width / 2;
            int titleHeight = 30;
            int subTitleHeight = 20;
            int datePageNoHeight = 20;


            // Fonts and formats
            Font printFont = new Font("Arial", 8);
            Font headingFont = new Font("Arial", 8, FontStyle.Bold);
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            StringFormat sfCenter = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            // Load and prepare the image
            Bitmap metroParkingImage = LoadMetroParkingImage(); // This should be a method that loads your image
            if (metroParkingImage == null) return;

            // Define reusable functions
            void PrintTitleAndHeaders()
            {
                int additionalTopMargin = 30;  // Set this to whatever value you need

                // Calculate image dimensions
                int imageWidth = 25;
                int imageHeight = 25;

                // Define title and sub-title
                string title = "METRO PARKING MANAGEMENT PHILS. INC.";
                string subTitle;
                if (_currentReportType == ReportType.WithDiscount)
                {
                    subTitle = "MONTHLY REPORT FOR DISCOUNTED CUSTOMER";
                }
                else if (_currentReportType == ReportType.OverStay)
                {
                    subTitle = "MONTHLY REPORT FOR OVERSTAYED CUSTOMER";
                }
                else
                {
                    subTitle = "MONTHLY DETAILED REPORT";
                }


                string datePageNo = $"DATE : {dtpMonthly.Value.ToString("MMMM, yyyy")}                   PAGE NO: {_pageIndex}";

                // Calculate sizes
                SizeF titleSize = e.Graphics.MeasureString(title, titleFont);
                SizeF subTitleSize = e.Graphics.MeasureString(subTitle, headingFont);

                // Create a larger font for datePageNo
                Font datePageNoFont = new Font("Arial", 9, FontStyle.Regular);
                SizeF datePageNoSize = e.Graphics.MeasureString(datePageNo, datePageNoFont);

                // Calculate combined width of image and title
                float combinedWidth = imageWidth + 5 + titleSize.Width;

                // Calculate starting X position for the combined image and title
                float startX = (e.PageBounds.Width - combinedWidth) / 2;

                // Set image position with additional top margin
                PointF imagePosition = new PointF(startX, topPadding + additionalTopMargin);

                // Set title position, adjusted for image width, with additional top margin
                PointF titlePosition = new PointF(startX + imageWidth + 10, topPadding + additionalTopMargin + (imageHeight - titleSize.Height) / 2);

                // Draw image
                e.Graphics.DrawImage(metroParkingImage, new RectangleF(imagePosition.X, imagePosition.Y, imageWidth, imageHeight));

                // Print title
                e.Graphics.DrawString(title, titleFont, Brushes.Black, titlePosition);

                // Print sub-title with additional top margin
                e.Graphics.DrawString(subTitle, headingFont, Brushes.Black, new PointF(pageCenter - (subTitleSize.Width / 2), topPadding + additionalTopMargin + imageHeight));

                // Print Date and Page Number with the larger font, with additional top margin
                e.Graphics.DrawString(datePageNo, datePageNoFont, Brushes.Black, new PointF(pageCenter - (datePageNoSize.Width / 2), topPadding + additionalTopMargin + imageHeight + subTitleHeight));

                // Adjust top margin for the data rows
                topMargin = topPadding + additionalTopMargin + imageHeight + subTitleHeight + datePageNoHeight + rowHeight * 2;

                DrawColumnHeaders(leftMargin);

                // Dispose of the larger font
                datePageNoFont.Dispose();
            }


            void DrawColumnHeaders(int margin)
            {
                // Add "#" to the beginning of the headers array
                string[] headers = { "#", "Ticket No.", "Plate No", "Time In", "Time Out", "Amt. Paid", "Vehicle Type", "Name", "Place", "Discount Info" };
                int xPosition = margin;
                for (int i = 0; i < headers.Length; i++)
                {
                    Rectangle rect = new Rectangle(xPosition, topMargin - rowHeight, columnWidths[i], rowHeight);
                    e.Graphics.DrawRectangle(Pens.Black, rect);
                    e.Graphics.DrawString(headers[i], headingFont, Brushes.Black, rect, sfCenter);
                    xPosition += columnWidths[i];
                }
            }


            // Print the page title and headers
            PrintTitleAndHeaders();


            if (_rowIndex == 0 && _pageIndex == 1)
            {
                // This is the first page
            }
            else if (_rowIndex > 0)
            {
                // This means we're continuing to print onto a new page
                if (_pageIndex == 0)
                {
                    _pageIndex = 1;
                }
                _pageIndex++;

            }

            // Print the rows
            while (_rowIndex < _dataToPrint.Rows.Count)
            {
                DataRow row = _dataToPrint.Rows[_rowIndex];

                // Check if we've reached the bottom of the page
                if (topMargin + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    if (_pageIndex == 1)
                    {
                        _pageIndex++;
                    }
                    break; // Break out of the loop to print this page and start a new one
                }

                // Draw the data for each row
                int xPosition = leftMargin;

                // Print the counter value
                string counterText = (_rowIndex + 1).ToString(); // Counter starts from 1
                Rectangle counterRect = new Rectangle(xPosition, topMargin, columnWidths[0], rowHeight);
                e.Graphics.DrawRectangle(Pens.Black, counterRect);
                e.Graphics.DrawString(counterText, printFont, Brushes.Black, counterRect, sfCenter);
                xPosition += columnWidths[0];

                // Print the rest of the data, starting from 1 as 0 is the counter
                for (int i = 1; i < columnWidths.Length; i++)
                {
                    string text = GetColumnText(row, i);
                    Rectangle rect = new Rectangle(xPosition, topMargin, columnWidths[i], rowHeight);
                    e.Graphics.DrawRectangle(Pens.Black, rect);
                    e.Graphics.DrawString(text, printFont, Brushes.Black, rect, sfCenter);
                    xPosition += columnWidths[i];
                }

                topMargin += rowHeight;
                _rowIndex++;
            }




            // Check for enough space to print the footer
            Font disclaimerFont = new Font("Arial", 8, FontStyle.Italic);
            Font nameFont = new Font("Arial", 10, FontStyle.Bold);
            Font reportFont = new Font("Arial", 8);
            int spaceRequiredForFooter = 4 * rowHeight + disclaimerFont.Height * 4; // Estimate the space needed
            if (topMargin + spaceRequiredForFooter > e.MarginBounds.Bottom)
            {
                e.HasMorePages = true;
                return; // Create a new page if not enough space
            }



            // Space between data and totals
            int spaceBetweenDataAndTotals = 20; // adjust as needed
            topMargin += spaceBetweenDataAndTotals;


            // Report Generated Text
            string reportGeneratedText = $"Report Generated: {DateTime.Now:MMMM d, yyyy hh:mmtt}";
            e.Graphics.DrawString(reportGeneratedText, reportFont, Brushes.Black, leftMargin, topMargin);
            topMargin += rowHeight;

            //line
            // Define a factor for adjusting the line length
            double lineLengthFactor = 0.45; // Example: 40% of the page width

            // Calculate the line length based on the factor
            int lineLength = (int)(e.PageBounds.Width * lineLengthFactor);

            // Calculate the end X-coordinate of the line
            int lineEndX = leftMargin + lineLength;

            // Draw the line
            Pen linePen = new Pen(Color.Black, 1);
            e.Graphics.DrawLine(linePen, leftMargin, topMargin, lineEndX, topMargin);

            // Increment the top margin for spacing after the line
            topMargin += rowHeight / 2;



            // Disclaimer Text
            string disclaimerText = "Disclaimer: The information provided in this report is for reference only and\ndoes not constitute legal or professional advice. The company is not\nresponsible for any errors or omissions, or for the results obtained from the\nuse of this information.";
            e.Graphics.DrawString(disclaimerText, disclaimerFont, Brushes.Black, leftMargin, topMargin);
            topMargin += disclaimerFont.Height * 4 + rowHeight;

            // Signature Line
            Pen signaturePen = new Pen(Color.Black, 2);
            float signatureLineLength = 200; // Adjust as needed
            e.Graphics.DrawLine(signaturePen, leftMargin, topMargin, leftMargin + signatureLineLength, topMargin);


            // Reduce Space between Signature Line and Admin's Name
            int spaceBetweenLineAndName = 5; // Reduced space
            topMargin += spaceBetweenLineAndName;  // This will bring the name closer to the signature line

            // Fetch Admin's Name
            (string username, string _, string fname, string mname, string lname) = databaseCodes.FetchAdminCredentials();
            string adminFullName = $"{fname} {mname} {lname}"; // Replace with databaseCodes.FetchAdminCredentials() if needed

            // Print Admin's Name and Role
            string role = "Chief In Charge";
            e.Graphics.DrawString(adminFullName, nameFont, Brushes.Black, leftMargin, topMargin);
            topMargin += nameFont.Height;
            e.Graphics.DrawString(role, nameFont, Brushes.Black, leftMargin, topMargin);
            topMargin += rowHeight;

            // Additional Note
            Font noteFont = new Font("Arial", 8, FontStyle.Italic);
            string signatureNote = "Signature confirms verification and approval of the report.";
            e.Graphics.DrawString(signatureNote, noteFont, Brushes.Black, new PointF(leftMargin, topMargin));
            topMargin += noteFont.Height;

            // Dispose of resources
            linePen.Dispose();
            disclaimerFont.Dispose();
            nameFont.Dispose();
            noteFont.Dispose();
            reportFont.Dispose();

            // Check if the print job is complete
            if (!_printSecondColumn && _rowIndex >= _dataToPrint.Rows.Count)
            {
                _rowIndex = 0;
                _pageIndex = 1;
                e.HasMorePages = false;
            }
            else
            {
                e.HasMorePages = true;
            }



        }


        private Bitmap LoadMetroParkingImage()
        {
            //header
            Bitmap metroParkingImage = null; // Initialize to null
            try
            {
                var assembly = GetType().Assembly;
                string resourceNamespace = "Metro_Parking_System.Images.metroparking.png";

                using (Stream stream = assembly.GetManifestResourceStream(resourceNamespace))
                {
                    if (stream == null)
                    {
                        MessageBox.Show("Error loading image: Resource not found.");
                        return null; // Return null if the resource is not found
                    }

                    metroParkingImage = new Bitmap(stream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
                return null; // Return null if there is an exception
            }

            return metroParkingImage; // Return the loaded image
        }

        private string GetColumnText(DataRow row, int columnIndex)
        {
            // Adjust the switch cases to account for the new counter column
            switch (columnIndex)
            {
                case 0:
                    return (_rowIndex + 1).ToString(); // Counter value
                case 1:
                    return row["id"].ToString(); // Ticket No., adjusted to case 1
                case 2:
                    return row["plateNumber"].ToString(); // Plate No., adjusted to case 2
                case 3:
                    return Convert.ToDateTime(row["TimeIn"]).ToString("MM-dd HH:mm"); // Time In, adjusted to case 3
                case 4:
                    return Convert.ToDateTime(row["TimeOut"]).ToString("MM-dd HH:mm"); // Time Out, adjusted to case 4
                case 5:
                    return row["Rate"].ToString(); // Amount Paid, adjusted to case 5
                case 6:
                    return row["vehicleType"].ToString(); // Vehicle Type, adjusted to case 6
                case 7:
                    return row["name"].ToString(); // Name, adjusted to case 7
                case 8:
                    return row["place"].ToString(); // Place, adjusted to case 8
                case 9:
                    return row["discountInfo"].ToString(); // Discount Info, adjusted to case 9
                default:
                    return string.Empty;
            }
        }

        private void UpdateDiscountButtonStatus(DateTime selectedDate)
        {
            DataTable dataWithDiscount = databaseCodes.GetParkingLogDataWithDiscountMonthly(selectedDate);

            // Check if the DataTable has any rows, which means there are vehicles with discounts
            btViewReportDiscount.Enabled = dataWithDiscount.Rows.Count > 0;
        }

        private void UpdateOverstayedButtonStatus(DateTime selectedDate)
        {
            DataTable dataWithOverstay = databaseCodes.GetParkingLogDataOverstayMonthly(selectedDate);

            // Check if the DataTable has any rows, which means there are vehicles with discounts
            btViewReportDiscount.Enabled = dataWithOverstay.Rows.Count > 0;
        }


        private void btViewReport_Click(object sender, EventArgs e)
        {
            _currentReportType = ReportType.Regular;
            DataTable data = databaseCodes.GetParkingLogDataMonthly(dtpMonthly.Value);
            ShowPrintPreviewReport(data);
        }

        private void btViewReportDiscount_Click(object sender, EventArgs e)
        {
            _currentReportType = ReportType.WithDiscount;
            DataTable data = databaseCodes.GetParkingLogDataWithDiscountMonthly(dtpMonthly.Value);
            ShowPrintPreviewReport(data);
        }

        private void dtpMonthly_ValueChanged(object sender, EventArgs e)
        {
            setStatus();
            UpdateDiscountButtonStatus(dtpMonthly.Value);
            UpdateOverstayedButtonStatus(dtpMonthly.Value);
        }

        private void setStatus()
        {
            // Get total vehicles count
            int totalVehicles = databaseCodes.GetParkingLogDataMonthly(dtpMonthly.Value).Rows.Count;

            // Get total discounted vehicles count
            int totalDiscountedVehicles = databaseCodes.GetParkingLogDataWithDiscountMonthly(dtpMonthly.Value).Rows.Count;
            int totalOverstayedVehicles = databaseCodes.GetParkingLogDataOverstayMonthly(dtpMonthly.Value).Rows.Count;

            // Update the text boxes with the retrieved counts
            tbTotalVehicle.Text = totalVehicles.ToString();
            tbTotalVehicleDiscounted.Text = totalDiscountedVehicles.ToString();
            tbTotalVehicleOverstay.Text = totalOverstayedVehicles.ToString();
            // Set status label and button availability based on the counts
            if (totalVehicles > 0)
            {
                lbStatusDaily.Text = "AVAILABLE";
                lbStatusDaily.ForeColor = Color.Green;
                btViewReport.Enabled = true;
                // Enable or disable btViewReportDiscount based on whether there are any discounted vehicles
                btViewReportDiscount.Enabled = totalDiscountedVehicles > 0;
                btViewReportOverstay.Enabled = totalOverstayedVehicles > 0;
            }
            else
            {
                lbStatusDaily.Text = "NO VEHICLES";
                lbStatusDaily.ForeColor = Color.Red;
                btViewReport.Enabled = false;
                btViewReportDiscount.Enabled = false;
                btViewReportOverstay.Enabled = false;
            }
        }

        private void ShowPrintPreviewReport(DataTable data)
        {
            _dataToPrint = data;
            _rowIndex = 0;
            _printSecondColumn = false;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btViewReportOverstay_Click(object sender, EventArgs e)
        {
            _currentReportType = ReportType.OverStay;
            DataTable data = databaseCodes.GetParkingLogDataOverstayMonthly(dtpMonthly.Value);
            ShowPrintPreviewReport(data);
        }
    }
}
