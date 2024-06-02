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
        const int SPEED_X = 5;
        public static int MaxX;
        public int speed_x;
        public int speed_y;
        public Line selfLine;
        

        public Actor(Dictionary<string, Sprite> states)
        {
            //sprite = s;
            //selfLine = new Line(s.x, s.x, s.y, s.y - s.img.Height);
            this.states = states;
        }

        public override void Update() //обновление координат объекта.
        {
            x += speed_x;
            y += speed_y;
            sprite.x = x;
            sprite.y = y;
            if (sprite.x < 0)
                SetStates("goLeft");        //????
            else if (sprite.x > 0)
                MoveRight();                //????
        }
        
        public void MoveLeft() //движение влево
        {
            x -= SPEED_X;
        }
        public void MoveRight() //движение вправо
        {
            x += SPEED_X;
        }
        public override void Stop()
        {
            x = 0;
            y = 0;
        }
    }
}
