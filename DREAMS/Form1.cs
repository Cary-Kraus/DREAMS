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
        MyGame game;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsManager.UpdateGraphics(e.Graphics);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new MyGame();
            Sprite sprite1 = new Sprite(@"Sprites\1.png");
            Sprite sprite2 = new Sprite(@"Sprites\2.png");
            //Sprite sprite3 = new Sprite(@"Sprites\3.png");
            Object o = new Object(sprite2);
            o.speed_x = 2;
            //game.PlaceObject(new Object(sprite1), 10, 10);
            game.PlaceObject(o, 150, 10);
            //GraphicsManager.AddSprite(sprite2, 150, 10);
            //GraphicsManager.AddSprite(sprite1, 10, 100);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.Update();
            Refresh();
        }
    }
}
