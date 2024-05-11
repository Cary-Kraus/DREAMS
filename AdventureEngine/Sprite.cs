using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Image = System.Drawing.Image;

namespace AdventureEngine
{
    public class Sprite : Object
    {
        internal Image img;
        internal Size size;

        public Sprite(string imagePath)
        {
            image = new Bitmap(imagePath);
            img = image;
        }
    }
}
