using System;
using System.Collections.Generic;
using System.Drawing;
using AdventureEngine;
using System.Threading;

namespace DREAMS
{
    public class MyGame : AdventureGame
    {     
        public static Sprite sForest1 = new Sprite(@"Sprites\лес1.png");
        public static Sprite sGhost0 = new Sprite(@"Sprites\ghost0.png");
        public static Sprite sGhost1 = new Sprite(@"Sprites\ghost1.png");
        public static Sprite sGhost2 = new Sprite(@"Sprites\ghost2.png");
        public static Sprite sActorLeft0 = new Sprite(@"Sprites\actorleft0.png");
        public static Sprite sActorRight0 = new Sprite(@"Sprites\actorright0.png");     
        public static Sprite sAngel1 = new Sprite(@"Sprites\angel1.png");
        public static Sprite sCrown = new Sprite(@"Sprites\crown.png");         

        Object ghostObj = new Object(sGhost0);
        Object angelObj = new Object(sAngel1);
        Object crownObj = new Object(sCrown);
        public Actor act;
        public MyGame()
        {
            act = new Girl();
            AddRoom("roomForest1", new Room(sForest1, new Line(0, 0, 0, 0)));
            AddRoom("roomForest2", new Room(sForest1, new Line(0, 0, 0, 0)));
            AddRoom("roomForest3", new Room(sForest1, new Line(0, 0, 0, 0)));
            SetMainActor(act);
            SetRoom("roomForest1");
            act.x = 1400;
            act.y = 450;
            PlaceObject(ghostObj, 200, 450);
            PlaceObject(crownObj, 1010, 450);
            crownObj.insideScript = ChangeToForest2;
            //PlaceObject(act, 600, 200);
            //CurrentRoom.Update();
            MyGame.StartScript(GhostMove);
        } 
        
        void ChangeToForest2()
        {
            SetRoom("roomForest2");
            act.x = 1400;
            act.y = 200;
        }

        void GhostMove()
        {
            Random r = new Random();
            while (true)
            {
                ghostObj.x += r.Next(-10, 10);
                ghostObj.y += r.Next(-10, 10);
                Thread.Sleep(50);
            }
        }
    }
}
