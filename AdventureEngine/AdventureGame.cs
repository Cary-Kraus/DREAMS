﻿using AdventureEngine;
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
        public void SetRoom(string room)
        {
            if (CurrentRoom != null && mainActor != null)
                mainActor.present = false;
            CurrentRoom = rooms[room];
            GraphicsManager.DelAll();
            GraphicsManager.AddSprite(CurrentRoom.sprite, 0, 0);
            PlaceObject(mainActor, 0, 0);
            CurrentRoom.mainActor = mainActor;
            mainActor.present = true;
        }

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

        }
        public void Update()
        {
            CurrentRoom.Update();
            //CurrentRoom.objects
        }
    }
}
