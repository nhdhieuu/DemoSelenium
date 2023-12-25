using System;
using System.Drawing;
using System.Drawing.Printing;

namespace SeleniumWPF
{
    
        public class PrintText
        {
            public PrintText(string text, Font font) : this(text, font, new StringFormat()) {}

            public PrintText(string text, Font font, StringFormat stringFormat)
            {
                Text = text;
                Font = font;
                StringFormat = stringFormat;
            }

            public string Text { get; set; }

            public Font Font { get; set; }

            /// <summary> Default is horizontal string formatting </summary>
            public StringFormat StringFormat { get; set; }
        }
        public class ReceiptItem
        {
            public string Name { get; set; }

            public decimal Cost { get; set; }

            public int Amount { get; set; }

            public int Discount { get; set; }

            public decimal Total { get { return Cost * Amount; } }
        }
        
    
}