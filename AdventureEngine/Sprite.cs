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
        public Image img;
        public Size size;
        public int x;
        public int y;
        public string name;

        public Sprite(Image image, string name)
        {
            img = image;
            x = 0;
            y = 0;
            this.name = name;
        }
        //public Sprite(string imagePath, int width, int height)
        //{            
        //    x = 0;
        //    y = 0;
        //    size = new Size(width, height);
        //    img = Image.FromFile(imagePath);                        
        //}
    }
}
