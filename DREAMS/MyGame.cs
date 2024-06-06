using System;
using System.Collections.Generic;
using System.Drawing;
using AdventureEngine;

namespace DREAMS
{
    public class MyGame : AdventureGame
    {
        static List<Sprite> allSprites = new List<Sprite>();

        //public static Sprite sForest1, sGhost0, sGhost1,
        //    sActorLeft0, sActorRight0, sActorLeft1, sActorRight1,
        //    sAngel1, sCrown;        

        public static Sprite sForest1 = new Sprite(Image.FromFile(@"Sprites\лес1.png"), "лес1");
        public static Sprite sGhost0 = new Sprite(Image.FromFile(@"Sprites\ghost0.png"), "призрак0");
        public static Sprite sGhost1 = new Sprite(Image.FromFile(@"Sprites\ghost1.png"), "призрак1");
        public static Sprite sActorLeft0 = new Sprite(Image.FromFile(@"Sprites\actorleft0.png"), "девочкаСтоитНалево");
        public static Sprite sActorRight0 = new Sprite(Image.FromFile(@"Sprites\actorright0.png"), "девочкаСтоитНаправо");
        public static Animation sActorLeft1 = new Animation(Image.FromFile(@"Sprites\actorleft11.png"), Image.FromFile(@"Sprites\actorleft12.png"), "девочкаИдетНалево");
        public static Animation sActorRight1 = new Animation(Image.FromFile(@"Sprites\actorright11.png"), Image.FromFile(@"Sprites\actorright12.png"), "девочкаИдетНаправо");
        public static Sprite sAngel1 = new Sprite(Image.FromFile(@"Sprites\angel1.png"), "ангел1");
        public static Sprite sCrown = new Sprite(Image.FromFile(@"Sprites\crown.png"), "корона1");         

        Object ghostObj = new Object(sGhost0);
        Object angelObj = new Object(sAngel1);
        Object crownObj = new Object(sCrown);
        public Actor act = new Actor(new Dictionary<string, Sprite>
            {
                { "Left", sActorLeft0},
                { "Right", sActorRight0},
                { "GoLeft", sActorLeft1},
                { "GoRight", sActorRight1}
            });
        public MyGame()
        {
            AddRoom("roomForest1", new Room(sForest1, new Line(0, 0, 0, 0)));
            AddRoom("roomForest2", new Room(sForest1, new Line(0, 0, 0, 0)));
            AddRoom("roomForest3", new Room(sForest1, new Line(0, 0, 0, 0)));
            SetMainActor(act);
            SetRoom("roomForest1");
            PlaceObject(ghostObj, 200, 450);
            PlaceObject(crownObj, 310, 200);
            //PlaceObject(act, 600, 200);
            //CurrentRoom.Update();
            
            
        }
            
    }
}
