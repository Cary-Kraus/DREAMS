using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DREAMS
{
    public partial class Form1 : Form
    {

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //foreach( var sprite in Sprite.GetAll())
            //    sprite.Draw(e.Graphics);

            //Sprite sprite1 = new Sprite(Image.FromFile("1.png"));
            //Animation.AddSprite(sprite1, new RectangleF(50, 50, 200, 200), e.Graphics);
        }
        public Form1()
        {
            InitializeComponent();

            Animation.Initialize(pictureBox1);
            Sprite sprite1 = new Sprite("1.png", 0, 0);
            Animation.AddSprite(sprite1);
        }
    }
}
