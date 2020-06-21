using System;
using System.Windows.Forms;

namespace img2ascii.View
{
    public partial class DisplayView : UserControl
    {
        public DisplayView()
        {
            InitializeComponent();
        }

        public void ButtonEnable(bool enable)
        {
            btnRestart.Enabled = enable;
            btnCopy.Enabled = enable;
        }

        public void SetProgress(Int32 progress, string text = null)
        {
            if (text == null) {
                text = lblProgress.Text;
            }

            lblProgress.Text = text;
            pbProgress.Value = progress;
        }
    }
}
