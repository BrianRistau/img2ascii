using img2ascii.Event;
using img2ascii.View;
using System.Threading;

namespace img2ascii.Presenter
{
    public class DisplayPresenter
    {
        private readonly DisplayView View;

        public DisplayPresenter(DisplayView view)
        {
            View = view;

            EventAggregator.Instance.Subscribe<StartGenerateEvent>(OnGenerateStart);
        }

        private void OnGenerateStart(StartGenerateEvent args)
        {
            View.ButtonEnable(false);
            View.SetProgress(0);

            // bjr ??? TODO:
            // Overview:
            // 0.5) ?? Convert image to grayscale before dithering ?? (research)
            // 1) Perform Floyd-Steinberg dithering on the input bitmap and 
            //    store the result in a new bitmap.
            // 2) Break dithered bitmap into blocks according to the output
            //    metadata size indications.
            // 3) Draw all of the character comparison bitmaps and store them
            //    in a HashMap for quick indexing.  Make sure that the size of
            //    the character bitmaps and the dithered bitmap blocks are
            //    identical and that the characters are drawn in a way that 
            //    reflects their size in a text field.
            // 4) Perform comparison on each of the dithered bitmaps to the 
            //    drawn character bitmaps and choose the best option.
            // 5) Add the selected character to an output string.  Do not 
            //    forget to add line-break characters (0x0A ?) after each "row"
            //    of blocks is complete.
        }
    }
}
