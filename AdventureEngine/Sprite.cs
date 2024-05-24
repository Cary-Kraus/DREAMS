using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureEngine
{
    public class Sprite : Object
    {
        internal Image img;
        internal Size size;
        public double x;
        public double y;

        public Sprite(string imagePath)
        {
            img = new Bitmap(imagePath);
            x = 0;
            y = 0;
        }
    }
}
