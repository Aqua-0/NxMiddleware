using BnTxx.Formats;
using System.Drawing;
using System.IO;

namespace BnTxx
{
    public class BNTX
    {
        public static Bitmap LoadFromFile(string file)
        {
            Bitmap bm = null;
            using (FileStream FS = new FileStream(file, FileMode.Open))
            {
                // Decode the texture so we can save it.
                BinaryTexture BT = new BinaryTexture(FS);

                PixelDecoder.TryDecode(BT.Textures[0], out Bitmap Img);
                bm = Img;
            }

            return bm;
        }
    }
}
