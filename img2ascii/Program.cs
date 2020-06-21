using System;
using System.Windows.Forms;
using img2ascii.View;
using img2ascii.Presenter;
using img2ascii.Logic;
using img2ascii.Event;

namespace img2ascii
{
    static class Program
    {
        private static MetadataManager _MetadataManager { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            _MetadataManager = new MetadataManager();

            OptionsView opView = new OptionsView();
            OptionsPresenter opPresenter = new OptionsPresenter(opView);
            SelectView isView = new SelectView();
            SelectPresenter isPresenter = new SelectPresenter(isView);
            DisplayView dView = new DisplayView();
            DisplayPresenter dPresenter = new DisplayPresenter(dView);

            opView.Tag = opPresenter;
            isView.Tag = isPresenter;
            dView.Tag = dPresenter;

            MainFormView mfView = new MainFormView(isView, opView, dView);
            MainFormPresenter mfPresenter = new MainFormPresenter(mfView);
            mfView.Tag = mfPresenter;

            Application.Run(mfView);
        }
    }
}
