using AdventureEngine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DREAMS
{
    public class Actor : Object
    {
        const int MAX_SPEED = 5;
        public static int MaxX;
        public static int MaxY;
        //protected int speed_x, speed_y;

        public Actor(Sprite s) : base(s)
        {
            sprite = s;
        }
        public override void Update() //обновление координат объекта. Если раскомментировать - будет двигаться
        {
            //x += speed_x;
            //y += speed_y;
            //sprite.x = x;
            //sprite.y = y;
        }
        public void MoveUp() //движение вверх
        {
            y--;
            sprite.y = y;
        }
        public void MoveDown() //движение вниз
        {
            y++;
            sprite.y = y;
        }
        public void MoveLeft() //движение влево
        {
            x--;
            sprite.x = x;
        }
        public void MoveRight() //движение вправо
        {
            x++;
            sprite.x = x;
        }
    }
}
