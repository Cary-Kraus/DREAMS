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
        public static Sprite sForest2 = new Sprite(@"Sprites\лес2.png");
        public static Sprite sDialogWindow = new Sprite(@"Sprites\диалоговое окно.png");
        public static Sprite sGhost0 = new Sprite(@"Sprites\ghost0.png");
        public static Sprite sGhost1 = new Sprite(@"Sprites\ghost1.png");
        public static Sprite sGhost2 = new Sprite(@"Sprites\ghost2.png");    
        public static Sprite sAngel1 = new Sprite(@"Sprites\angel1.png");
        public static Sprite sCrown = new Sprite(@"Sprites\crown.png");
        public static Animation anActGoLeft = new Animation(new List<string>() 
        { 
            @"Sprites\act\go\left\1.png",
            @"Sprites\act\go\left\2.png",
            @"Sprites\act\go\left\3.png",
            @"Sprites\act\go\left\4.png",
            @"Sprites\act\go\left\5.png",
            @"Sprites\act\go\left\6.png",
            @"Sprites\act\go\left\7.png",
            @"Sprites\act\go\left\8.png", 
        });
        public static Animation anActGoRight = new Animation(new List<string>()
        {
            @"Sprites\act\go\right\1.png",
            @"Sprites\act\go\right\2.png",
            @"Sprites\act\go\right\3.png",
            @"Sprites\act\go\right\4.png",
            @"Sprites\act\go\right\5.png",
            @"Sprites\act\go\right\6.png",
            @"Sprites\act\go\right\7.png",
            @"Sprites\act\go\right\8.png",
        });

        //Object dialogWndw = new Object(sDialogWindow);
        Object ghostObj = new Object(sGhost0);
        Object angelObj = new Object(sAngel1);
        Object crownObj = new Object(sCrown);
        public Actor act;
        public MyGame()
        {
            act = new Girl();
            AddRoom("roomForest1", new Room(sForest1, new Line(900, 1100, 450, 450)));
            AddRoom("roomForest2", new Room(sForest1, new Line(0, 0, 0, 0)));
            AddRoom("roomForest3", new Room(sForest1, new Line(0, 0, 0, 0)));
            SetMainActor(act);
            SetRoom("roomForest1");
            act.x = 1400;
            act.y = 450;
            PlaceObject(ghostObj, 200, 450);
            PlaceObject(crownObj, 318, 260);
            //crownObj.insideScript = ChangeToForest2;
            //act.insideScript = ChangeToForest2; //пересечение с линией комнаты
            act.insideScript = StartDialogWithGhost; //пересечение с линией комнаты
            //StartScript(GhostMove);
        }

        void ChangeToForest2()
        {
            SetRoom("roomForest2");
            act.x = 1400;
            act.y = 450;
        }
        void ChangeToForest3()
        {
            SetRoom("roomForest3");
            act.x = 1400;
            act.y = 450;
        }

        void StartDialogWithGhost()
        {
            GraphicsManager.AddSprite(sDialogWindow, 0, 670);
            act.Stop();
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
