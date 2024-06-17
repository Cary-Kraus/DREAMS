using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureEngine
{
    public class Sprite
    {
        public Image img;
        public Size size;
        public int x;
        public int y;
        public int z;
        public int tag;

        public Sprite(string name)
        {
            img = Image.FromFile(name);
            x = 0;
            y = 0;
            size.Width = img.Width;
            size.Height = img.Height;
        }

        public Sprite()
        {

        }


        public virtual void Update()
        {

        }

        public override bool Equals(object obj)
        {
            return obj is Sprite sprite &&
                   EqualityComparer<Image>.Default.Equals(img, sprite.img) &&
                   EqualityComparer<Size>.Default.Equals(size, sprite.size) &&
                   x == sprite.x &&
                   y == sprite.y;
        }
    }
}
