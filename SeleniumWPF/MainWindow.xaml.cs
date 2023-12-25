using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows;
using OpenQA.Selenium;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Controls;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using PrintDocument = System.Drawing.Printing.PrintDocument;

namespace SeleniumWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>  
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private PrintText printText;
        private PrintDocument printDocument = new PrintDocument();
        private PrintDialog printDialog = new PrintDialog();

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var doc = new PrintDocument();
            doc.PrintPage += new PrintPageEventHandler(PrintPageHandler);
            doc.Print();
        }


        public void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            const int FIRST_COL_PAD = 20;
            const int SECOND_COL_PAD = 7;
            const int THIRD_COL_PAD = 20;

            var sb = new StringBuilder();
            sb.AppendLine("Start of receipt");
            sb.AppendLine("================");
            ReceiptItem item = new ReceiptItem
            {
                Name = "Item 1",
                Cost = 1.99m,
                Amount = 1,
                Discount = 0
            };
            
            sb.Append(item.Name.PadRight(FIRST_COL_PAD));

            var breakDown = item.Amount > 0 ? item.Amount + "x" + item.Cost : string.Empty;
            sb.Append(breakDown.PadRight(SECOND_COL_PAD));

            sb.AppendLine(string.Format("{0:0.00} A", item.Total).PadLeft(THIRD_COL_PAD));

            if (item.Discount > 0)
            {
                sb.Append(string.Format("DISCOUNT {0:D2}%", item.Discount)
                    .PadRight(FIRST_COL_PAD + SECOND_COL_PAD));
                sb.Append(string.Format("{0:0.00} A", -(item.Total / 100 * item.Discount)).PadLeft(THIRD_COL_PAD));
                sb.AppendLine();
                
            }

            sb.AppendLine("================");
            var printText = new PrintText(sb.ToString(), new Font("Monospace Please...", 20));

            Graphics g = e.Graphics;
            RectangleF pageRectangle = e.PageSettings.PrintableArea; 
            SizeF pageSize = pageRectangle.Size;

            float layoutWidth = pageSize.Width;
            float layoutHeight = 0f;

            var layoutArea = new SizeF(layoutWidth, layoutHeight);

            // Đo kích thước chuỗi cần in
            SizeF stringSize = g.MeasureString(printText.Text, printText.Font, layoutArea, printText.StringFormat);

            // Tính toán vị trí giữa trang
            float centerX = (pageSize.Width - stringSize.Width) / 2;
            float centerY = (pageSize.Height - stringSize.Height) / 2 - 100;

            // Vẽ chuỗi ở giữa trang
            RectangleF rectf = new RectangleF(centerX, centerY, stringSize.Width, stringSize.Height);
            g.DrawString(printText.Text, printText.Font, Brushes.Black, rectf, printText.StringFormat);

        }

        public void ProvideContent(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);

            float fontHeight = font.GetHeight();

            int startX = 0;
            int startY = 0;
            int Offset = 20;


            PaperSize paperSize = new PaperSize("Custom", 50, 100);

            e.PageSettings.PaperSize = paperSize;
            graphics.DrawString("Welcome to MSST", new Font("Courier New", 8),
                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

            graphics.DrawString("Ticket No:" + "4525554654545",
                new Font("Courier New", 14),
                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;


            graphics.DrawString("Ticket Date :" + "21/12/215",
                new Font("Courier New", 14),
                new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            String underLine = "------------------------------------------";

            graphics.DrawString(underLine, new Font("Courier New", 14),
                new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            String Grosstotal = "Total Amount to Pay = " + "2566";

            Offset = Offset + 20;
            underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 14),
                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

            graphics.DrawString(Grosstotal, new Font("Courier New", 14),
                new SolidBrush(Color.Black), startX, startY + Offset);
        }


        private void ButtonBase1_OnClick(object sender, RoutedEventArgs e)
        {
            PrintJob printJob = new PrintJob();
            printJob.Print();
        }
    }
}