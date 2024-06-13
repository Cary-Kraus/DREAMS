using AdventureEngine;
using System;
using System.Collections.Generic;

namespace AdventureEngine
{
    /// <summary>
    /// Игровая локация.
    /// Sprite - фон;
    /// Line - невидимая линия, при столкновении с которой что-то происходит (или нет)
    /// objects - список все объектов текущей локации
    /// </summary>
    public class Room : Object
    {
        Line line;
        public List<Object> objects;
        public Actor mainActor;
        public int roomHeigt;
        public int roomWidht;

        public Room(Sprite sprite, Line line) : base(sprite)
        {
            this.line = line;
            this.sprite = sprite;
            objects = new List<Object>();
            roomHeigt = sprite.size.Height;
            roomWidht = sprite.size.Width - 140; //отнимается ширина спрайта actor
            //нужно сделать line вместо границ комнаты.
            //Тогда переход из одной комнаты в другую может быть открыт или закрыт
            //можно сделать наследника line door, у него будет состояние opened/closed
        }

        /// <summary>
        /// Обновляет комнату
        /// и проверяет линию на столкновения с персонажем и в случае столкновения вызывает скрипт
        /// </summary>
        public override void Update()
        {
            foreach (Object o in objects)
            {
                if (o.selfLine.IsInside(mainActor.selfLine) && line.IsInside(mainActor.selfLine) && o.insideScript != null )
                    o.insideScript();
                if (o.x >= roomWidht)//столкновение с границей комнаты
                    o.x -= 5;
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

        public void DelObject(Object obj)
        {
            objects.Remove(obj);
            GraphicsManager.DelSprite(obj.sprite);
        }
    }
}
