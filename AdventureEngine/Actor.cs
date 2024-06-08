using AdventureEngine;
using System;
using System.Collections.Generic;

namespace DREAMS
{
    public class Actor : Object
    {
        const int SPEED_X = 2;
        public static int MaxX;
        
        
        public Actor(Sprite left, Sprite right) : base(left)
        {                       
            states = new Dictionary<string, Sprite>()
            {
                { "Left", left },
                { "Right", right }
            };
            currentState = "Left";
        }
        
        public void MoveLeft() //движение влево
        {         
            SetState("Left");
            x -= SPEED_X;
        }
        public void MoveRight() //движение вправо
        {           
            SetState("Right");
            x += SPEED_X;
        }
        public override void Stop()
        {
            //running = false;
        }
    }
}
