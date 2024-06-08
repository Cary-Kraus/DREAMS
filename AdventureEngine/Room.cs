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
        public Actor mainActor;

        public Room(Sprite sprite, Line line) : base(sprite)
        {
            this.line = line;
            this.sprite = sprite;
            objects = new List<Object>();
        }

        /// <summary>
        /// Обновляет комнату (пока что нет)
        /// и проверяет линию на столкновения с персонажем и в случае столкновения вызывает скрипт
        /// </summary>
        public override void Update()
        {
            foreach (Object o in objects)
            {
                if (o.selfLine.IsInside(mainActor.selfLine) && line.IsInside(mainActor.selfLine) && o.insideScript != null )
                    o.insideScript();
                o.Update();
            }
            List<Object> objs = new List<Object>();
            foreach (Object o in objects)
                if (o.present)
                    objs.Add(o);
            objects = objs;
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
