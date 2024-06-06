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
        public Actor mainActor;
        //public List<Object> objects;


        public AdventureGame()
        {
            rooms = new Dictionary<string, Room>();
        }

        public void AddRoom(string name, Room room)
        {
            rooms.Add(name, room);
        }
        public void SetRoom(string room)
        {
            CurrentRoom = rooms[room];
            GraphicsManager.AddSprite(CurrentRoom.sprite, 0, 0);
            if (mainActor != null)
                PlaceObject(mainActor, 1400, 450);
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
        }        
        public void DelObject(Object o)
        {
            CurrentRoom.objects.Remove(o);
        }
        public void SetMainActor(Actor actor)
        {
            mainActor = actor;
            
        }
        private static void StartScript()
        {

        }
        private static void StopScript()
        {

        }
        public void Update()
        {
            CurrentRoom.Update();
            //CurrentRoom.objects
        }
    }
}
