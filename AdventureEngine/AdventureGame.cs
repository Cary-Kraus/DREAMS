using AdventureEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DREAMS
{
    
    public class AdventureGame
    {
        List<Object> objects;
        public Dictionary<string, Room> rooms;            
        public Room CurrentRoom;


        public AdventureGame()
        {
            objects = new List<Object>();
        }

        private void AddRoom(Room room)
        {
            
        }
        public void SetRoom(Room room)
        {
            CurrentRoom = room;
            GraphicsManager.AddSprite(room.sprite,0,0);
        }
        private static void GoToRoom(Room room)
        {

        }
        public void PlaceObject(Object o, int x, int y)
        {
            o.x = x;
            o.y = y;
            objects.Add(o);
            GraphicsManager.AddSprite(o.sprite, x, y);
        }

        
        public void DelObject(Object o)
        {
            objects.Remove(o);
        }
        private static void StartScript()
        {

        }
        private static void StopScript()
        {

        }
        public static void Update()
        {

        }
    }
}
