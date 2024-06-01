using AdventureEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DREAMS
{
    public class Room : Object
    {
        Line line;
        public List<Object> objects;
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
                    if (a.selfLine.IsInside())
                        o.Update(); //обновление движения
                    else
                        o.Stop();//останавливаем/обнуляем скорость 
                }
            }

        }
    }
}
