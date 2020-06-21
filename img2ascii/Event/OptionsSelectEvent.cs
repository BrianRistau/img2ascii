using img2ascii.Model;

namespace img2ascii.Event
{
    public class OptionsSelectEvent : IApplicationEvent
    {
        public OutputMetadata Metadata { get; private set; }
    
        public OptionsSelectEvent(OutputMetadata metadata)
        {
            Metadata = metadata;
        }
    }
}
