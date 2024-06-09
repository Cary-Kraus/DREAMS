using AdventureEngine;
using System;
using System.Collections.Generic;

namespace DREAMS
{
    public class Actor : Object
    {
        public const int SPEED_X = 3;
        //public readonly int SPEED_X = 3;
        public static int MaxX;      
        
        public Actor(Sprite left, Sprite right, Sprite runLeft, Sprite runRight) : base(left)
        {                       
            states = new Dictionary<string, Sprite>()
            {
                { "Left", left },
                { "Right", right },
                {"RunLeft", runLeft },
                {"RunRight", runRight }
            };
            currentState = "Left";
        }
        
        public void MoveLeft() //движение влево
        {
            x -= SPEED_X;
            SetState("RunLeft");        
        }
        public void MoveRight() //движение вправо
        {
            x += SPEED_X;
            SetState("RunRight");    
        }
        public override void Stop()
        {
            //поменять анимацию бега на стоячую
            if (currentState == "RunLeft")
                SetState("Left");
            if (currentState == "RunRight")
                SetState("Right");
        }
        /// <summary>
        /// Запрещает пользователю усправлять перемещением персонажа с помошью клавиш
        /// </summary>
        public void BunRun()
        {
            //обнулить скорость
            //или
            if()
        }
    }
}
