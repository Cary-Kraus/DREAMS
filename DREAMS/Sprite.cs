using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace DREAMS
{
    internal class Sprite : Object
    {
        internal Image img;
        internal Size size;

        protected static List<Sprite> sprites = new List<Sprite>();
        public Sprite(string imagePath)
        {
            Bitmap image = new Bitmap(imagePath);
            img = image;
        }

        public static List<Sprite> GetAll()
        {
            return sprites;
        }

    }
}
