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
        public static Sprite sAngel1 = new Sprite(@"Sprites\angel1.png");
        public static Sprite sCrown1 = new Sprite(@"Sprites\crownV.png");
        public static Sprite sCrown2 = new Sprite(@"Sprites\crownH.png");

        //Object ghostObj = new Object(sGhost0);
        AdventureEngine.Object angelObj = new AdventureEngine.Object(sAngel1);
        AdventureEngine.Object crownObj = new Item(sCrown1);
        Text caption;
        Ghost ghost;
        public Actor act;
        bool first = false;
        //public Text text1;
        public MyGame()
        {
            act = new Girl();
            ghost = new Ghost();
            AddRoom("roomForest1", new Room(sForest1, new Line(900, 1100, 450, 450)));
            AddRoom("roomForest2", new Room(sForest2, new Line(0, 0, 0, 0)));
            AddRoom("roomForest3", new Room(sForest1, new Line(0, 0, 0, 0)));
            SetMainActor(act);
            SetRoom("roomForest1");
            act.x = 1400;
            act.y = 450;
            act.inventory = new List<object>();
            AdventureEngine.Object trigger = new AdventureEngine.Object(null, 200, 0);
            PlaceObject(ghost, 240, 450);
            PlaceObject(crownObj, 290, 230);
            PlaceObject(trigger, 1000, 230);
            //crownObj.insideScript = ChangeToForest2;
            //act.insideScript = ChangeToForest2; //пересечение с линией комнаты
            trigger.insideScript = StartDialogWithGhost; //пересечение с линией комнаты
            //StartScript(GhostMove);
        }

        void ChangeToForest2()
        {
            SetRoom("roomForest2");
            PlaceObject(angelObj, 750, 130);
            act.x = 1400;
            act.y = 450;
        }
        void ChangeToForest3()
        {
            SetRoom("roomForest3");
            act.x = 1400;
            act.y = 450;
        }

        void StartDialog()
        {

        }
        void StartDialogWithGhost()
        {
            if (first) return;
            Text tempText = new Text(Text.GetTextFromFile(1), 50, 700) ;
            GraphicsManager.AddSprite(tempText.sprite, 0, 670);
            GraphicsManager.AddText(50, 700, tempText);
            PlaceObject(tempText, 50, 700);
            act.Stop(); //остановить
            act.BunRun(); //запретить перемещение
            Thread.Sleep(50);            
            first = true;
            tempText.clickScript = GhostMove;
            //Thread.SpinWait  -  ?
            //Thread.Yeild  -  ?
        }
        void GhostMove()
        {
            Random r = new Random();
            while (true)
            {
                ghost.x += r.Next(-10, 10);
                ghost.y += r.Next(-10, 10);
                Thread.Sleep(50);
            }
        }
    }
}
