using AdventureEngine;
using System;
using System.Collections.Generic;

namespace DREAMS
{
    public class Room : Object
    {
        Line line;
        public List<Object> objects;
        public Room(Sprite sprite, Line line) : base(sprite)
        {
            this.line = line;
            this.sprite = sprite;
            objects = new List<Object>();
        }
        public void PlaceRoom()
        {

        }
        public override void Update()
        {
            foreach (Object o in objects)
            {
                if (o is Actor)//проверка на столкновения гг
                {
                    Actor a = (Actor)o;
                    if (a.selfLine.IsInside(new Line(100, 100, 350, 450)))
                    {                                                
                        o.Stop();
                        o.x--;
                        o.Update(); //обновление движения actor
                    }
                    else
                        o.Update(); //обновление состояния actor
                }
                else
                    o.Update();//пустой метод
            }            
        }

        public void PlaceObject(Object o, int x, int y)
        {
            o.x = x;
            o.y = y;
            objects.Add(o);
            GraphicsManager.AddSprite(o.sprite, x, y);
        }
    }
}
