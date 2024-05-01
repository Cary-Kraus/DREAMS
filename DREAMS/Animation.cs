using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DREAMS
{
    internal static class Animation
    {
        private static PictureBox pictureBox;
        public static void Initialize(PictureBox pb)
        {
            pictureBox = pb;
        }
        internal static void AddSprite(Sprite sprite)
        {
            //g.DrawImage(sprite.img, 50, 50);
            pictureBox.Controls.Add(sprite.GetPictureBox());
        }
        static void ChangeSprite(Sprite sprite1, Sprite sprite2, Graphics g)
        {

        }
        static void DelSprite(Sprite sprite, /*Graphics g*/ Form Form1)
        {

        }
        static void DelAll(Sprite sprite, Graphics g)
        {
            g.Clear(Color.White);
        }
        static void AddAll(Sprite sprite)
        {

        }
    }
}
