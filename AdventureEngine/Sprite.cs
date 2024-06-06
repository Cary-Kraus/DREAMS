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

        public void Update()
        {

        }

        public override bool Equals(object obj)
        {
            return obj is Sprite sprite &&
                   EqualityComparer<Image>.Default.Equals(img, sprite.img) &&
                   EqualityComparer<Size>.Default.Equals(size, sprite.size) &&
                   x == sprite.x &&
                   y == sprite.y &&
                   name == sprite.name;
        }
    }
}
