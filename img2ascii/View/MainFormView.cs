using System;
using System.Windows.Forms;

namespace img2ascii.View
{
    public partial class MainFormView : Form, IMainFormView
    {
        private readonly SelectView SelectView;
        private readonly OptionsView OptionsView;
        private readonly DisplayView DisplayView;

        public MainFormView(SelectView isView, OptionsView opView, DisplayView idView)
        {
            isView.Dock = DockStyle.Fill;
            opView.Dock = DockStyle.Fill;
            idView.Dock = DockStyle.Fill;

            SelectView = isView;
            OptionsView = opView;
            DisplayView = idView;

            InitializeComponent();
            ShowSelectScreen();
        }

        public void ShowSelectScreen()
        {
            Controls.Clear();
            Controls.Add(SelectView);
            Invalidate();
        }

        public void ShowOptionsScreen()
        {
            Controls.Clear();
            Controls.Add(OptionsView);
            Invalidate();
        }

        public void ShowDisplayScreen()
        {
            Controls.Clear();
            Controls.Add(DisplayView);
            Invalidate();
        }
    }
}
