using img2ascii.Model;

namespace img2ascii.Event
{
    public class ImageSelectEvent : IApplicationEvent
    {
        public InputMetadata Metadata { get; private set; }

        public ImageSelectEvent(InputMetadata metadata)
        {
            Metadata = metadata;
        }
    }
}
