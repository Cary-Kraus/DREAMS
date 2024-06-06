using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureEngine
{
    public class Animation : Sprite
    {
        public Image[] images;
        public Image img;
        public string name;

        public Animation(Image img, Image img2, Image img3, string name) : base(img, name)
        {
            x = 0;
            y = 0;
            this.name = name;
            images = new Image[] { img, img2, img3 };
            this.img = img;
        }
        public Animation(Image img, Image img2, string name) : base(img, name)
        {
            x = 0;
            y = 0;
            this.name = name;
            images = new Image[] { img, img2 };
            this.img = img;
        }
        public override void Update()
        {
            //при каждом вызове этого метод текущий спрайт должен меняться на след.
            if (img.Equals(images[0]))
                img = images[1];
            if (img.Equals(images[1]))
                img = images[2];
            if (img.Equals(images[2]))
                img = images[3];
        }
    }
}
