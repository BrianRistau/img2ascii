using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace img2ascii.Extensions
{
    /// <summary>
    /// Class that provides static graphics extension methods.
    /// </summary>
    public static class GraphicsExtensions
    {
        /// <summary>
        /// Method to generate a RoundedRectangle path.
        /// </summary>
        /// <param name="bounds">The shape bounds.</param>
        /// <param name="radius">The corner radius.</param>
        /// <returns>A RoundedRectangle graphics path.</returns>
        private static GraphicsPath RoundedRectangle(Rectangle bounds, Int32 radius)
        {
            Int32 diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top-left
            path.AddArc(arc, 180, 90);

            // top-right
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom-right
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom-left
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        /// <summary>
        /// Method to draw a rounded rectangle.
        /// </summary>
        /// <param name="graphics">The graphics object.</param>
        /// <param name="pen">The pen to draw with.</param>
        /// <param name="bounds">The shape bounds.</param>
        /// <param name="radius">The corner radius.</param>
        public static void DrawRoundedRectangle(this Graphics graphics, Pen pen, Rectangle bounds, Int32 radius)
        {
            if (graphics == null) {
                throw new ArgumentNullException("graphics");
            }
            if (pen == null) {
                throw new ArgumentNullException("pen");
            }

            using (GraphicsPath path = RoundedRectangle(bounds, radius))
            {
                graphics.DrawPath(pen, path);
            }
        }

        /// <summary>
        /// Method to fill a rounded rectangle.
        /// </summary>
        /// <param name="graphics">The graphics object.</param>
        /// <param name="brush">The brush to draw with.</param>
        /// <param name="bounds">The shape bounds.</param>
        /// <param name="radius">The corner radius.</param>
        public static void FillRoundedRectangle(this Graphics graphics, Brush brush, Rectangle bounds, Int32 radius)
        {
            if (graphics == null) {
                throw new ArgumentNullException("graphics");
            }
            if (brush == null) {
                throw new ArgumentNullException("brush");
            }

            using (GraphicsPath path = RoundedRectangle(bounds, radius))
            {
                graphics.FillPath(brush, path);
            }
        }
    }
}
