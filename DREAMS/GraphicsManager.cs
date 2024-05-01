using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DREAMS
{
    internal static class GraphicsManager
    {
        internal static void AddSprite(Sprite sprite, Graphics g)
        {
            g.DrawImage(sprite.img, new Rectangle(0, 0, 200, 200));
        }
        static void ChangeSprite(Sprite sprite1, Sprite sprite2, Graphics g)
        {

        }
        static void DelSprite(Sprite sprite, Graphics g)
        {

        }
        static void DelAll(Sprite sprite, Graphics g)
        {
            g.Clear(Color.White);
        }
        static void AddAll(Sprite sprite, Graphics g)
        {

        }
    }
}
