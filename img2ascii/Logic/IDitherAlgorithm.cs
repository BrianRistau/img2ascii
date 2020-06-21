using System.Drawing;

namespace img2ascii.Logic
{
    public interface IDitherAlgorithm
    {
        Bitmap Dither(Bitmap input);
    }
}
