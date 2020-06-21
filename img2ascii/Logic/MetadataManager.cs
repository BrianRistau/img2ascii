using img2ascii.Event;
using img2ascii.Model;

namespace img2ascii.Logic
{
    public class MetadataManager
    {
        public InputMetadata InputMetadata { get; private set; }

        public OutputMetadata OutputMetadata { get; private set; }

        public MetadataManager()
        {
            EventAggregator.Instance.Subscribe<ImageSelectEvent>(OnImageSelect);
            EventAggregator.Instance.Subscribe<OptionsSelectEvent>(OnOptionsSelect);
        }

        private void OnImageSelect(ImageSelectEvent args)
        {
            if (args.Metadata == null) {
                return;
            }

            InputMetadata = args.Metadata;
        }

        private void OnOptionsSelect(OptionsSelectEvent args)
        {
            if (args.Metadata == null) {
                return;
            }

            OutputMetadata = args.Metadata;
            EventAggregator.Instance.Publish(new StartGenerateEvent());
        }
    }
}
