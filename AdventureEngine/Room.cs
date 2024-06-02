using AdventureEngine;
using System.Collections.Generic;

namespace DREAMS
{
    public class Room : Object
    {
        Line line;
        public List<Object> objects = new List<Object>();
        public Room(Sprite sprite, Line line) : base(sprite, line)
        {
            this.line = line;
            this.sprite = sprite;
        }
        public void PlaceRoom()
        {

        }
        public override void Update()
        {
            foreach (Object o in objects)
            {
                if (o is Actor)
                {
                    Actor a = (Actor)o;
                    if (a.selfLine.IsInside(new Line(100, 100, 350, 450)))
                    {
                        a.x--;
                        o.Update(); //обновление движения
                    }                        
                    else
                        o.Stop();//останавливаем/обнуляем скорость 
                }
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
