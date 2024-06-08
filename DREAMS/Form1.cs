using System;
using System.Windows.Forms;
using System.Drawing;
using AdventureEngine;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

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

        private void Form1_KeyDown(object sender, KeyEventArgs e) //движение по клавишам WASD
        {
            if (e.KeyData == Keys.A || e.KeyData == Keys.Left)
            {
                game.act.MoveLeft();
            }

            if (e.KeyData == Keys.D || e.KeyData == Keys.Right)
            {
                game.act.MoveRight();
            }            
              //key up 
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }
    }
}
