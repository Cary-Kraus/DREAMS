using AdventureEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdventureEngine
{
    
    public class AdventureGame
    {
        public Dictionary<string, Room> rooms;
        public List<Script> scripts = new List<Script>();
        public static Room CurrentRoom = null;
        public static Text curText = null;
        public Actor mainActor;
        public delegate void Script();

        public AdventureGame()
        {
            rooms = new Dictionary<string, Room>();  
            //заполнить список скриптов
        }

        public void AddRoom(string name, Room room)
        {
            rooms.Add(name, room);
        }

        /// <summary>
        /// Устанавливает комнату как текущую. 
        /// </summary>
        /// <param name="room"></param>
        public void SetRoom(string room)
        {
            if (CurrentRoom != null && mainActor != null)
                mainActor.present = false; //удаляем actor из текущей комнаты
            CurrentRoom = rooms[room]; //меняяем текущую комнату
            GraphicsManager.DelAll(); //удаляем все спрайты
            GraphicsManager.AddSprite(CurrentRoom.sprite, 0, 0); //добавляем фон
            PlaceObject(mainActor, 0, 0); //помещаем actor
            CurrentRoom.mainActor = mainActor;
            mainActor.present = true; //добавляем actor
        }
        /// <summary>
        /// Поместить объект в текущую комнату
        /// </summary>
        /// <param name="o"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void PlaceObject(Object o, int x, int y)
        {
            o.x = x;
            o.y = y;
            CurrentRoom.PlaceObject(o, x, y);
        }        
        public void DelObject(Object o)
        {
            CurrentRoom.objects.Remove(o);
        }
        public void SetMainActor(Actor actor)
        {
            mainActor = actor;            
        }
        public void StartScript(ThreadStart script) //static?
        {
            new Thread(script).Start();
        }
        public void StopScript(Thread script) //static?
        {
            //нужен список
            script.Abort();
            //Script script1 = scripts.Find(p => p == script);
        }
        public void Update()
        {
            CurrentRoom.Update();
        }
        /// <summary>
        /// проверка кликов по объектам
        /// </summary>
        /// <param name="MouseX">координата мыши по x</param>
        /// <param name="MouseY">координата мыши по y</param>
        public void CheckMouseClick(int MouseX, int MouseY)
        {
            foreach (Object obj in CurrentRoom.objects)
            {
                if (obj is Item)
                {
                    //находим actor и вызываем у него PickUpObject
                    CurrentRoom.objects[CurrentRoom.objects.FindIndex((p) => p is Actor)].PickUpObject(obj);
                    CurrentRoom.DelObject(obj);
                    GraphicsManager.DelSprite(obj.sprite);
                }
                if (MouseX >= obj.x && MouseX <= obj.x + obj.width)
                    if (MouseY >= obj.y && MouseY <= obj.y + obj.height)
                        obj.StartScriptClick();
            }
        }
        public bool CheckMouseMove(int MouseX, int MouseY)
        {
            foreach (Object obj in CurrentRoom.objects)
            {
                if (MouseX >= obj.x && MouseX <= obj.x + obj.width &&
                   MouseY >= obj.y && MouseY <= obj.y + obj.height)
                        return true;
                    else continue;
            }
            return false;
        }
    }
}
