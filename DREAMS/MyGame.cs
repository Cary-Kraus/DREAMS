using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DREAMS
{
    public class MyGame
    {
        public PictureBox pictureBox1;
        public void Initialize()
        {
            Animation.Initialize(pictureBox1);

            Sprite sprite1 = new Sprite("1.png", 0, 0);
            Animation.AddSprite(sprite1);
        }
    }
}
