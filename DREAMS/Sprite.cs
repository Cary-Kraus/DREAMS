using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace DREAMS
{
    internal class Sprite : Object
    {
        internal Image img;
        internal Size size;
        private PictureBox pictureBox;

        protected static List<Sprite> sprites = new List<Sprite>();
        public Sprite(string imagePath, int x, int y)
        {
            Bitmap image = new Bitmap(imagePath);
            pictureBox = new PictureBox
            {
                Image = image,
                Location = new Point(x, y),
                Size = image.Size
            };
        }
        public PictureBox GetPictureBox()
        {
            return pictureBox;
        }
        public static List<Sprite> GetAll()
        {
            return sprites;
        }
        //public virtual void Draw(Graphics g)
        //{
        //    g.DrawImage(image, new PointF(coords.X - image.Width / 2, coords.Y - image.Height / 2));
        //}
    }
}
