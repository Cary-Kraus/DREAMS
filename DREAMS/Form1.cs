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
        Actor act;
        Room room;
        Line lin;
        

        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsManager.UpdateGraphics(e.Graphics);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new MyGame();

            game.rooms[1].
            Sprite backgroundForest = new Sprite(MyGame.imForest1);
            Sprite ghost = new Sprite(MyGame.imGhost0);
            Sprite actor = new Sprite(MyGame.imActorLeft0);
            Sprite angel = new Sprite(MyGame.imWeepingAngel1);
            lin = new Line(0, 0, 50, 50);
            room = new Room(backgroundForest, lin);
            Object ghostObj = new Object(ghost);
            Object angelObj = new Object(angel);
            act = new Actor(actor);
            act.SetStates(new Dictionary<string, Sprite>
            { 
                {"Stand", actor} 
            });
            //act.speed_x = 2;
            //act.speed_y = 1;
            game.PlaceObject(room, 0, 0);
            game.PlaceObject(act, 300, 450);
            game.PlaceObject(ghostObj, 200, 450);
            game.PlaceObject(angelObj, 600, 200);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //game.Update();
            room.Update();
            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) //движение по клавишам WASD
        {
            if (e.KeyData == Keys.A && e.KeyData == Keys.Left)
                act.MoveLeft();
            if (e.KeyData == Keys.D && e.KeyData == Keys.Right)
                act.MoveRight();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }
    }
}
