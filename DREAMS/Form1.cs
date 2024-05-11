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
            Sprite sprite1 = new Sprite(@"Sprites\1.png");
            Sprite sprite2 = new Sprite(@"Sprites\2.png");
            Sprite sprite3 = new Sprite(@"Sprites\3.png");

            GraphicsManager.AddSprite(sprite1, 10, 50);
            GraphicsManager.UpdateGraphics(e.Graphics);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
            
        }
    }
}
