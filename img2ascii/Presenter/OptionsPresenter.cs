using img2ascii.Event;
using img2ascii.Model;
using img2ascii.View;
using System;
using System.Diagnostics;
using System.Drawing;

namespace img2ascii.Presenter
{
    public class OptionsPresenter
    {
        private readonly OptionsView View;

        private InputMetadata Metadata;

        public OptionsPresenter(OptionsView view)
        {
            View = view;
            View.GenerateClick += OnGenerateClick;

            EventAggregator.Instance.Subscribe<ImageSelectEvent>(OnImageSelected);
        }

        /// <summary>
        /// Method that is called when an image is selected.
        /// </summary>
        /// <param name="args">The event arguments.</param>
        private void OnImageSelected(ImageSelectEvent args)
        {
            Metadata = args.Metadata;
            View.AspectRatio = Metadata.AspectRatio;
        }

        private void OnGenerateClick(object sender, EventArgs args)
        {
            OutputMetadata options = new OutputMetadata(View.OutputSize);
            EventAggregator.Instance.Publish(new OptionsSelectEvent(options));
        }
    }
}
