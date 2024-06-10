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

namespace DREAMS
{
    
    public class AdventureGame
    {
        public Dictionary<string, Room> rooms;            
        public static Room CurrentRoom = null;
        public static Text curText = null;
        public Actor mainActor;
        delegate void Script();

        public AdventureGame()
        {
            rooms = new Dictionary<string, Room>();
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
        public static void StartScript(ThreadStart script)
        {
            new Thread(script).Start();
        }
        public static void StopScript()
        {
            //создать список скриптов 
        }
        public void Update()
        {
            CurrentRoom.Update();
        }
        public void CheckClick(int MouseX, int MouseY)
        {
            foreach ( Object obj in CurrentRoom.objects)
            {
                if (MouseX >= obj.sprite.x && MouseX <= obj.sprite.x + obj.sprite.img.Width)
                    if (MouseY >= obj.sprite.y && MouseY <= obj.sprite.y + obj.sprite.img.Height)
                        obj.StartScriptClick();
            }
        }
    }
}
