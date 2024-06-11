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
        public List<object> inventory;
        public bool stop_input = false;
        
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
            z = 20;
        }
        
        public void MoveLeft() //движение влево
        {
            if (stop_input) 
                return;
            x -= SPEED_X;
            SetState("RunLeft");
        
        }
        public void MoveRight() //движение вправо
        {
            if (stop_input)
                return;
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
            stop_input = true;
        }
        public void PickUpObject(Object obj)
        {
            inventory.Add(obj);
        }
    }
}
