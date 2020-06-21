using img2ascii.Extensions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace img2ascii.View
{
    public partial class SelectView : UserControl
    {
        private const Int32 BUTTON_WIDTH = 155;
        private const Int32 BUTTON_HEIGHT = 45;
        private readonly Color BUTTON_COLOR = Color.AliceBlue;
        private const Int32 BUTTON_BORDER_RADIUS = 5;
        private const Single BUTTON_BORDER_WIDTH = 1.2f;
        private readonly Color BUTTON_BORDER_COLOR = Color.DarkSlateGray;
        private const Single BUTTON_FONT_SIZE = 14f;
        public readonly Color BUTTON_FONT_COLOR = Color.FromArgb(0x1C, 0x1C, 0x26);
        private readonly FontFamily BUTTON_FONT_FAMILY = FontFamily.GenericSansSerif;

        private readonly Pen ButtonCornerPen;
        private readonly Brush ButtonBrush;
        private readonly Brush ButtonTextBrush;
        private readonly Font ButtonTextFont;
        private readonly StringFormat ButtonTextFormat;

        public SelectView()
        {
            InitializeComponent();

            ButtonCornerPen = new Pen(BUTTON_BORDER_COLOR, BUTTON_BORDER_WIDTH);
            ButtonBrush = new SolidBrush(BUTTON_COLOR);
            ButtonTextBrush = new SolidBrush(BUTTON_FONT_COLOR);
            ButtonTextFont = new Font(BUTTON_FONT_FAMILY, BUTTON_FONT_SIZE);

            ButtonTextFormat = new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center
            };
        }

        /// <summary>
        /// Method called to paint the ImageSelectView
        /// </summary>
        /// <param name="sender">The event caller.</param>
        /// <param name="args">The event arguments.</param>
        private void ImageSelectView_Paint(object sender, PaintEventArgs args)
        {
            Int32 x, y;
            Rectangle bounds = args.ClipRectangle;
            Graphics graphics = args.Graphics;

            x = (bounds.Width - BUTTON_WIDTH) / 2;
            y = (bounds.Height - BUTTON_HEIGHT) / 2;
            Rectangle rectangle = new Rectangle(x, y, BUTTON_WIDTH, BUTTON_HEIGHT);
            graphics.FillRoundedRectangle(ButtonBrush, rectangle, BUTTON_BORDER_RADIUS);
            graphics.DrawRoundedRectangle(ButtonCornerPen, rectangle, BUTTON_BORDER_RADIUS);

            graphics.DrawString("Select Image...", ButtonTextFont, ButtonTextBrush, rectangle, ButtonTextFormat);
        }
    }
}
