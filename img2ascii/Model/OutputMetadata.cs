using System;
using System.Drawing;

namespace img2ascii.Model
{
    /// <summary>
    /// Class that represents the options to use during the dithering and
    /// conversion procedures.
    /// </summary>
    public class OutputMetadata
    {
        public Size OutputSize { get; private set; }

        public OutputMetadata(Size outputSize)
        {
            OutputSize = outputSize;
        }
    }
}
