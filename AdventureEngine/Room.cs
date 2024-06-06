using AdventureEngine;
using System;
using System.Collections.Generic;

namespace DREAMS
{
    /// <summary>
    /// Представляет собой комнату, 
    /// имеющую собственный спрайт (фон),
    /// список объектов, находящихся в ней а также линию столкновения с персонажем
    /// </summary>
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
        /// <summary>
        /// Обновляет комнату (пока что нет)
        /// и проверяет линию на столкновения с персонажем
        /// </summary>
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
                    }
                    o.Update();
                }
                else
                    o.Update();
            }            
        }
        /// <summary>
        /// Добавляет объект в комнату и рисует его
        /// </summary>
        /// <param name="o"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void PlaceObject(Object o, int x, int y)
        {
            o.x = x;
            o.y = y;
            objects.Add(o);
            GraphicsManager.AddSprite(o.sprite, x, y);
        }
    }
}
