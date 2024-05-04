using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdventureEngine;

namespace DREAMS
{
    public partial class Form1 : Form
    {
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            InitializeComponent();
            //GraphicsManager.AddSprite(new Sprite("1.png"), e.Graphics);
            GraphicsManager.DrawAll(e.Graphics);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Sprite sprite1 = new Sprite("Sprites/1.png", 10, 10);
            //Sprite sprite2 = new Sprite("Sprites/2.png", 50, 70);
            //Sprite sprite3 = new Sprite("Sprites/3.png", 100, 150);
        }
        public Form1()
        {
            InitializeComponent();
            //Sprite sprite1 = new Sprite(@"Sprites\1.png", 10, 10);
            //Sprite sprite2 = new Sprite(@"Sprites\2.png", 50, 70);
            //Sprite sprite3 = new Sprite(@"Sprites\3.png", 100, 150);

            Sprite sprite1 = new Sprite("1.png", 10, 10);
            Sprite sprite2 = new Sprite("2.png", 50, 70);
            Sprite sprite3 = new Sprite("3.png", 100, 150);
        }
    }
}
