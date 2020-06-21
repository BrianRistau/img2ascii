using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace img2ascii.View
{
    public partial class OptionsView : UserControl
    {
        public event EventHandler GenerateClick;

        private Single _AspectRatio;
        public Single AspectRatio { 
            get { return _AspectRatio; }
            set
            {
                if (value == 0.0f) {
                    return;
                }

                _AspectRatio = value;
                OutputSizeChanged(this, null);
            } 
        }

        public Size OutputSize
        {
            get
            {
                Size size = new Size();
                if (AspectRatio > 1.0f)
                {
                    size.Width = scrOutputSize.Value;
                    size.Height = (Int32)(scrOutputSize.Value / AspectRatio);
                }
                else if (AspectRatio < 1.0f)
                {
                    size.Width = (Int32)(scrOutputSize.Value * AspectRatio);
                    size.Height = scrOutputSize.Value;
                }
                return size;
            }
        }

        public OptionsView()
        {
            InitializeComponent();

            AspectRatio = 1.0f;
            scrOutputSize.Value = 32;
        }

        private void OnGenerateClick(object sender, EventArgs args)
        {
            GenerateClick?.Invoke(sender, args);
        }

        private void OutputSizeChanged(object sender, EventArgs e)
        {
            Int32 width, height;
            if (AspectRatio > 1.0f) {
                width = scrOutputSize.Value;
                height = (Int32)(scrOutputSize.Value / AspectRatio);
            }
            else {
                width = (Int32)(scrOutputSize.Value * AspectRatio);
                height = scrOutputSize.Value;
            }

            lblOutputSizeValue.Text = string.Format("{0} x {1}", width, height);
        }
    }
}
