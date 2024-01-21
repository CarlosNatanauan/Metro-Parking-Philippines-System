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

namespace Metro_Parking_System.AdmUserControls.Report_Generation.Report_Buttons
{
    public partial class UC_Yearly : UserControl
    {

        private DataTable _dataToPrint;
        private int _rowIndex;
        private bool _printSecondColumn;
        private int _pageIndex = 1;

        //total for printing
        private int _totalVehicles = 0;
        private double _totalRevenue = 0.0;

        public UC_Yearly()
        {
            InitializeComponent();
            this.dtpYearly.Value = DateTime.Now;
            dtpYearly.Format = DateTimePickerFormat.Custom;
            dtpYearly.CustomFormat = "yyyy";
            btViewReport.Enabled = false;
            setStatus();
            
        }

        private void setStatus()
        {
            int selectedYear = dtpYearly.Value.Year;

            DataTable data = databaseCodes.GetParkingLogDataYearly(selectedYear);

            // Get total vehicles and total revenue from the database
            (int totalVehicles, double totalRevenue) = databaseCodes.GetYearlyTotals(selectedYear);

            // Update the textboxes
            tbTotalVehicle.Text = totalVehicles.ToString();
            CultureInfo peso = new CultureInfo("en-PH");
            peso.NumberFormat.CurrencySymbol = "₱";
            tbTotalRevenue.Text = totalRevenue.ToString("C", peso);

            // Set status label and button availability
            if (totalVehicles > 0)
            {
                lbStatusDaily.Text = "AVAILABLE";
                lbStatusDaily.ForeColor = Color.Green;
                btViewReport.Enabled = true;
            }
            else
            {
                lbStatusDaily.Text = "UNAVAILABLE";
                lbStatusDaily.ForeColor = Color.Red;
                btViewReport.Enabled = false;
            }
        }



        private void dpYearly_ValueChanged(object sender, EventArgs e)
        {
            setStatus();
        }

        private void btViewReport_Click(object sender, EventArgs e)
        {
            int selectedYear = dtpYearly.Value.Year;
            DataTable data = databaseCodes.GetParkingLogDataYearly(selectedYear);
            ShowPrintPreviewReport(data);
        }

        private void ShowPrintPreviewReport(DataTable data)
        {
            _dataToPrint = data;
            _rowIndex = 0;
            _printSecondColumn = false;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }



        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int topPadding = 10;// sa taas
            int initialTopMargin = 90 + topPadding;
            int topMargin = initialTopMargin;
            int rowHeight = 20;
            int[] columnWidths = { 40, 60, 80, 70, 70, 70 }; // Added 50 for counter
            int totalColumnWidth = columnWidths.Sum();
            int spaceBetweenBatches = 10;// sa gitna
            int leftPadding = 325;//sa gilid

            int leftMargin = CalculateLeftMargin(totalColumnWidth, false);

            Font printFont = new Font("Arial", 8);
            Font headingFont = new Font("Arial", 8, FontStyle.Bold);
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            StringFormat sfCenter = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            int titleHeight = 30;
            int subTitleHeight = 20;
            int datePageNoHeight = 20;

            int pageCenter = e.PageBounds.Width / 2;


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


            void PrintTitleAndHeaders()
            {
                int additionalTopMargin = 30;  // Set this to whatever value you need

                // Calculate image dimensions
                int imageWidth = 25;
                int imageHeight = 25;

                // Define title and sub-title
                string title = "METRO PARKING MANAGEMENT PHILS. INC.";
                string subTitle = "YEARLY REVENUE REPORT";
                string datePageNo = $"YEAR : {dtpYearly.Value.ToString("yyyy")}                   PAGE NO: {_pageIndex}";

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

                // Draw headers
                DrawColumnHeaders(leftMargin);

                // Dispose of the larger font
                datePageNoFont.Dispose();
            }


            int CalculateLeftMargin(int totalWidth, bool secondColumn)
            {
                int pageWidth = e.PageBounds.Width - e.MarginBounds.Left - e.MarginBounds.Right;
                int spaceAvailable = pageWidth - 2 * totalWidth - spaceBetweenBatches;
                if (secondColumn)
                    return e.MarginBounds.Left + totalWidth + spaceBetweenBatches + spaceAvailable / 2 + leftPadding;
                else
                    return e.MarginBounds.Left + spaceAvailable / 2 + leftPadding;
            }

            void DrawColumnHeaders(int margin)
            {
                // Add "Counter" to the beginning of the headers array
                string[] headers = { "#", "Ticket No.", "Plate No", "Time In", "Time Out", "Amt. Paid" };
                int xPosition = margin;
                for (int i = 0; i < headers.Length; i++)
                {
                    Rectangle rect = new Rectangle(xPosition, topMargin - rowHeight, columnWidths[i], rowHeight);
                    e.Graphics.DrawRectangle(Pens.Black, rect);
                    e.Graphics.DrawString(headers[i], headingFont, Brushes.Black, rect, sfCenter);
                    xPosition += columnWidths[i];
                }
            }

            PrintTitleAndHeaders();

            while (_rowIndex < _dataToPrint.Rows.Count)
            {
                DataRow row = _dataToPrint.Rows[_rowIndex];

                if (topMargin + rowHeight > e.MarginBounds.Bottom)
                {
                    if (!_printSecondColumn)
                    {
                        leftMargin = CalculateLeftMargin(totalColumnWidth, true);
                        topMargin = initialTopMargin;
                        _printSecondColumn = true;
                    }
                    else
                    {
                        e.HasMorePages = true;
                        _printSecondColumn = false;
                        leftMargin = CalculateLeftMargin(totalColumnWidth, false);
                        topMargin = initialTopMargin;
                        _pageIndex++;
                        return;
                    }

                    PrintTitleAndHeaders();
                }

                int xPosition = leftMargin;
                // Print the counter value
                string counterText = (_rowIndex + 1).ToString(); // Counter starts from 1
                Rectangle counterRect = new Rectangle(xPosition, topMargin, columnWidths[0], rowHeight);
                e.Graphics.DrawRectangle(Pens.Black, counterRect);
                e.Graphics.DrawString(counterText, printFont, Brushes.Black, counterRect, sfCenter);
                xPosition += columnWidths[0];

                // Print the rest of the data
                for (int i = 0; i < columnWidths.Length - 1; i++)
                {
                    string text = "";
                    if (i == 0) text = row["id"].ToString();
                    else if (i == 1) text = row["plateNumber"].ToString();
                    else if (i == 2) text = Convert.ToDateTime(row["TimeIn"]).ToString("MM-dd HH:mm");
                    else if (i == 3) text = Convert.ToDateTime(row["TimeOut"]).ToString("MM-dd HH:mm");
                    else if (i == 4) text = row["Rate"].ToString();

                    Rectangle rect = new Rectangle(xPosition, topMargin, columnWidths[i + 1], rowHeight);
                    e.Graphics.DrawRectangle(Pens.Black, rect);
                    e.Graphics.DrawString(text, printFont, Brushes.Black, rect, sfCenter);
                    xPosition += columnWidths[i + 1];
                }

                topMargin += rowHeight;
                _rowIndex++; _totalVehicles++;
                _totalRevenue += Convert.ToDouble(row["Rate"]);

            }

            if (topMargin + 2 * rowHeight > e.MarginBounds.Bottom)
            {
                e.HasMorePages = true;
                return;
            }


            if (_rowIndex >= _dataToPrint.Rows.Count)
            {
                // Fonts
                Font totalFont = new Font("Arial", 10, FontStyle.Bold);
                Font reportFont = new Font("Arial", 8);

                Font regularFont = new Font("Arial", 10, FontStyle.Regular);
                Font boldFont = new Font("Arial", 10, FontStyle.Bold);

                // Line Pen
                Pen linePen = new Pen(Color.Black, 1);

                // Space between data and totals
                int spaceBetweenDataAndTotals = 20; // adjust as needed
                topMargin += spaceBetweenDataAndTotals;

                // Calculate line positions
                float lineYPos1 = topMargin;
                float lineYPos2 = topMargin + 3 * rowHeight + 10;

                // Draw top line
                e.Graphics.DrawLine(linePen, leftMargin, lineYPos1, leftMargin + totalColumnWidth, lineYPos1);

                // Total Vehicles
                string totalVehiclesLabel = "TOTAL VEHICLES: ";
                string totalVehiclesValue = _totalVehicles.ToString();
                SizeF labelSize = e.Graphics.MeasureString(totalVehiclesLabel, regularFont);

                e.Graphics.DrawString(totalVehiclesLabel, regularFont, Brushes.Black, leftMargin, topMargin + 5);
                e.Graphics.DrawString(totalVehiclesValue, boldFont, Brushes.Black, leftMargin + labelSize.Width, topMargin + 5);
                topMargin += rowHeight;

                CultureInfo peso = new CultureInfo("en-PH");
                peso.NumberFormat.CurrencySymbol = "₱";

                // Total Revenue
                string totalRevenueLabel = "TOTAL REVENUE: ";
                string totalRevenueValue = _totalRevenue.ToString("C", peso);
                labelSize = e.Graphics.MeasureString(totalRevenueLabel, regularFont);


                e.Graphics.DrawString(totalRevenueLabel, regularFont, Brushes.Black, leftMargin, topMargin + 5);
                e.Graphics.DrawString(totalRevenueValue, boldFont, Brushes.Black, leftMargin + labelSize.Width, topMargin + 5);
                topMargin += rowHeight;


                // Draw bottom line
                e.Graphics.DrawLine(linePen, leftMargin, lineYPos2, leftMargin + totalColumnWidth, lineYPos2);
                // Report Generated
                string reportGeneratedText = $"Report Generated: {DateTime.Now:MMMM d, yyyy hh:mmtt}";
                e.Graphics.DrawString(reportGeneratedText, reportFont, Brushes.Black, leftMargin, topMargin + 15);
                topMargin += rowHeight;


                // Disclaimer
                string disclaimerText = "Disclaimer: The information provided in this report is for reference only and does not constitute legal or professional advice. The company is not responsible for any errors or omissions, or for the results obtained from the use of this information.";
                Font disclaimerFont = new Font("Arial", 8, FontStyle.Italic);
                // Draw disclaimer text
                RectangleF disclaimerRect = new RectangleF(leftMargin, topMargin + 15, totalColumnWidth, disclaimerFont.Height * 4);
                e.Graphics.DrawString(disclaimerText, disclaimerFont, Brushes.Black, disclaimerRect);
                // Space between data and totals
                int spaceDisclaimerAndSignature = 20; // adjust as needed
                topMargin += spaceDisclaimerAndSignature;
                topMargin += (disclaimerFont.Height * 4) + 20;  // Adding space after the disclaimer

                // Fetch Admin's Name
                (string username, string _, string fname, string mname, string lname) = databaseCodes.FetchAdminCredentials();
                string adminFullName = $"{fname} {mname} {lname}";

                // Signature Line
                Pen signaturePen = new Pen(Color.Black, 2);
                float signatureLineLength = 200; // Adjust as needed
                e.Graphics.DrawLine(signaturePen, leftMargin, topMargin, leftMargin + signatureLineLength, topMargin);

                // Reduce Space between Signature Line and Admin's Name
                int spaceBetweenLineAndName = 5; // Reduced space
                topMargin += spaceBetweenLineAndName;  // This will bring the name closer to the signature line

                // Print Admin's Name and Role
                Font nameFont = new Font("Arial", 10, FontStyle.Bold);
                string role = "Chief In Charge";
                e.Graphics.DrawString(adminFullName, nameFont, Brushes.Black, leftMargin, topMargin);
                topMargin += nameFont.Height;
                e.Graphics.DrawString(role, nameFont, Brushes.Black, leftMargin, topMargin);
                topMargin += nameFont.Height;

                // Additional Disclaimer or Note
                Font noteFont = new Font("Arial", 8, FontStyle.Italic);
                string signatureNote = "Signature confirms verification and approval of the report.";
                e.Graphics.DrawString(signatureNote, noteFont, Brushes.Black, new PointF(leftMargin, topMargin));
                topMargin += noteFont.Height;

                // Dispose of Fonts and Pen
                signaturePen.Dispose();
                nameFont.Dispose();
                noteFont.Dispose();

                e.HasMorePages = false;
                _rowIndex = 0;
                _pageIndex = 1;
                _printSecondColumn = false;

                // Reset totals for the next print job
                _totalVehicles = 0;
                _totalRevenue = 0.0;

                // Dispose of Fonts and Pen
                totalFont.Dispose();
                reportFont.Dispose();
                linePen.Dispose();
            }
        }
    }
}
