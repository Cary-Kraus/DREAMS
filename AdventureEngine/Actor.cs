using AdventureEngine;
using System;
using System.Collections.Generic;

namespace DREAMS
{
    public class Actor : Object
    {
        const int SPEED_X = 5;
        public static int MaxX;
        public Line selfLine;
        
        public Actor(Dictionary<string, Sprite> states)
        {                       
            this.states = states;
            sprite = states["Left"];
            selfLine = new Line(sprite.x, sprite.x, sprite.y, sprite.y - sprite.img.Height);
        }
        public Actor()
        {

        }

        public override void Update() //обновление координат объекта
        {
            Console.WriteLine($"Обновление координат спрайта {sprite.name} actor");
            
            sprite.x = x;
            sprite.y = y;

            Console.WriteLine($"X = {sprite.x}");
            Console.WriteLine($"Y = {sprite.y}");
        }
        
        public void MoveLeft() //движение влево
        {
            x -= SPEED_X;
            Console.WriteLine($"MoveLeft. x = {x}");
            SetStates("GoLeft");
            Update();
        }
        public void MoveRight() //движение вправо
        {
            x += SPEED_X;
            SetStates("GoRight");
            Update();
        }
        public override void Stop()
        {
            x = 0;
            Update();
        }
    }
}
