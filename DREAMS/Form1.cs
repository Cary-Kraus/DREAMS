using System;
using System.Windows.Forms;
using AdventureEngine;

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
            Sprite background = new Sprite(@"Sprites\фон.png");
            Sprite sprite2 = new Sprite(@"Sprites\2.png");
            Sprite sprite3 = new Sprite(@"Sprites\3.png");
            lin = new Line(0, 0, 50);
            room = new Room(background, lin);
            Object o2 = new Object(sprite2);
            act = new Actor(sprite3);
            //act.speed_x = 2;
            //act.speed_y = 1;
            //game.PlaceObject(o1, 10, 10);
            game.PlaceObject(room, 0, 0);
            game.PlaceObject(act, 100, 100);
            
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
            if (e.KeyData == Keys.W)
                act.MoveUp();
            if (e.KeyData == Keys.S)
                act.MoveDown();
            if (e.KeyData == Keys.A)
                act.MoveLeft();
            if (e.KeyData == Keys.D)
                act.MoveRight();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"Click {Cursor.Position.X}, {Cursor.Position.Y}");
            act.CalcDistnc(Cursor.Position.X, Cursor.Position.Y);
        }
    }
}
