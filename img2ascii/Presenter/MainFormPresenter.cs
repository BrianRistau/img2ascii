using img2ascii.Event;
using img2ascii.View;

namespace img2ascii.Presenter
{
    public class MainFormPresenter
    {
        private readonly IMainFormView View;

        public MainFormPresenter(IMainFormView view)
        {
            View = view;

            EventAggregator.Instance.Subscribe<ImageSelectEvent>(OnImageSelected);
            EventAggregator.Instance.Subscribe<OptionsSelectEvent>(OnOptionsSelected);
        }

        /// <summary>
        /// Method that is called when an image is selected.
        /// </summary>
        /// <param name="args">The event arguments.</param>
        private void OnImageSelected(ImageSelectEvent args)
        {
            if (args.Metadata == null) {
                return;
            }
            
            View.ShowOptionsScreen();
        }

        private void OnOptionsSelected(OptionsSelectEvent args)
        {
            if (args.Metadata == null) {
                return;
            }

            View.ShowDisplayScreen();
        }
    }
}
