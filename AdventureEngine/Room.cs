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
        /// <summary>
        /// границы комнаты или во всю ширину или ограничены, где можно ходить
        /// </summary>
        Line line;
        /// <summary>
        /// текущий список объектов
        /// </summary>
        public List<Object> objects;
        /// <summary>
        /// временный список объектов для добавления
        /// </summary>
        public List<Object> tobjects;
        public Actor mainActor;
        public int roomHeigt;
        public int roomWidht;

        public Room(Sprite sprite, Line line) : base(sprite)
        {
            this.line = line;
            this.sprite = sprite;
            objects = new List<Object>();
            tobjects = new List<Object>();
            roomHeigt = sprite.size.Height;
            roomWidht = sprite.size.Width - 140; //отнимается ширина спрайта actor
            //нужно сделать line - граница комнаты.

            //тогда в комнате может быть несколько line (список в конструктор)
            //Тогда переход из одной комнаты в другую может быть открыт или закрыт
            //можно сделать наследника line door, у него будет состояние opened/closed
            //но тк line не наследуется от object, у door:line не будет спрайта или можно его добавить
            //тогда его отдельно нужно добавлять в список с objects, хотя объектом он являться не будет
        }

        /// <summary>
        /// Обновляет комнату
        /// и проверяет линию на столкновения с персонажем и в случае столкновения вызывает скрипт
        /// </summary>
        public override void Update()
        {
             objects.Clear();
            foreach (Object o in tobjects)
                objects.Add(o);
            
            foreach (Object o in objects)
            {               
                o.Update();
                //if (o == mainActor && o.selfLine.IsInside(mainActor.selfLine))
                // проверяем если o - mainActor и внутри line комнаты
                // если нет то возвращаем mainActor
                if (o.selfLine.IsInside(mainActor.selfLine) && o.insideScript != null )
                    o.insideScript();             
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
            tobjects.Add(o);
            if (o.visible)
                GraphicsManager.AddSprite(o.sprite, x, y);
        }

        public void DelObject(Object obj)
        {
            objects.Remove(obj);
            if (obj.visible)
                GraphicsManager.DelSprite(obj.sprite);
        }
    }
}
