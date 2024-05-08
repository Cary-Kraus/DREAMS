using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
using AdventureEngine;

namespace DREAMS
{
    internal class Sprite : Object
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
