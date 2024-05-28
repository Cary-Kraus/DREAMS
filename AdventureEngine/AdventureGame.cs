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
        Dictionary<int, string> rooms = new Dictionary<int, string>()
        {
            { 1, "Forest"},
            { 2, "Cave"},
            { 3, "Weald"}
        };
        public static Image imForest1 = Image.FromFile(@"Sprites\лес1.png");
        //public static Image imForest2 = Image.FromFile(@"Sprites\лес2.png");
        //public static Image imForest3 = Image.FromFile(@"Sprites\лес3.png");

        public static Image imActorRight0 = Image.FromFile(@"Sprites\actorright0.png"); //стоит вправо
        public static Image imActorLeft0 = Image.FromFile(@"Sprites\actorleft0.png"); //стоит влево
        //public static Image imActorRight1 = Image.FromFile(@"Sprites\actor1.gif"); //анимация ходьбы вправо
        //public static Image imActorLeft1 = Image.FromFile(@"Sprites\actor1.gif"); //анимация ходьбы влево

        public static Image imGhost0 = Image.FromFile(@"Sprites\ghost0.png"); //стоит
        //public static Image imGhost1 = Image.FromFile(@"Sprites\ghost1.png"); //пугает
        //public static Image imGhost2 = Image.FromFile(@"Sprites\ghost2.png"); //сильно пугает

        //public static Image imWeepingAngel = Image.FromFile(@"Sprites\angel.png");
        //public static Image imRing = Image.FromFile(@"Sprites\ring.png");

        public AdventureGame()
        {
            objects = new List<Object>();
        }

        private static void AddRoom(Room room)
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
