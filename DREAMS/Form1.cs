using System;
using System.Windows.Forms;
using System.Drawing;
using AdventureEngine;
using System.Drawing.Drawing2D;

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
            
            Sprite backgroundForest = new Sprite(AdventureGame.imForest1);
            Sprite sprite2 = new Sprite(AdventureGame.imGhost0);
            Sprite sprite3 = new Sprite(AdventureGame.imActorLeft0);
            lin = new Line(0, 0, 50);
            room = new Room(backgroundForest, lin);
            Object o2 = new Object(sprite2);
            act = new Actor(sprite3);
            //act.speed_x = 2;
            //act.speed_y = 1;
            game.PlaceObject(room, 0, 0);
            game.PlaceObject(act, 300, 450);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.Update();
            Refresh();
            Console.WriteLine($"{act.x} {act.y}");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) //движение по клавишам WASD
        {
            //if (e.KeyData == Keys.W)
            //    act.MoveUp();
            //if (e.KeyData == Keys.S)
            //    act.MoveDown();
            if (e.KeyData == Keys.A)
                act.MoveLeft();
            if (e.KeyData == Keys.D)
                act.MoveRight();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"Click {Cursor.Position.X}, {Cursor.Position.Y}");
            act.CalcDistnc(Cursor.Position.X);
        }
    }
}
