using AdventureEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DREAMS
{
    
    public class AdventureGame
    {
        List<Object> objects;

        public AdventureGame()
        {
            objects = new List<Object>();
        }

        private static void AddRoom()
        {

        }
        private static void GoToRoom()
        {

        }
        public void PlaceObject(Object o, int x, int y)
        {
            o.x = x;
            o.y = y;
            objects.Add(o);
            GraphicsManager.AddSprite(o.sprite, x, y);
        }

        public void Update()
        {
            foreach (Object o in objects)
                o.Update();
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
    }
}
