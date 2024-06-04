using AdventureEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DREAMS
{
    
    public class AdventureGame
    {
        public Dictionary<string, Room> rooms;            
        public static Room CurrentRoom;
        //public List<Object> objects;


        public AdventureGame()
        {
            //комнаты
        }

        private void AddRoom(Room room)
        {
            
        }
        public void SetRoom(Room room)
        {
            CurrentRoom = room;
            GraphicsManager.AddSprite(room.sprite,0,0);
            //Console.WriteLine($"Комната {room} установлена");
        }
        private static void GoToRoom(Room room)
        {

        }
        public void PlaceObject(Object o, int x, int y)
        {
            o.x = x;
            o.y = y;
            CurrentRoom.objects.Add(o);
            GraphicsManager.AddSprite(o.sprite, x, y);
            //Console.WriteLine($"Объект {o} размещен");
        }

        
        public void DelObject(Object o)
        {
            CurrentRoom.objects.Remove(o);
        }
        private static void StartScript()
        {

        }
        private static void StopScript()
        {

        }
        public static void Update()
        {
            CurrentRoom.Update();
            //CurrentRoom.objects
        }
    }
}
