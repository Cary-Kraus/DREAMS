using System.Collections.Generic;
using System.Drawing;
using AdventureEngine;

namespace DREAMS
{
    public class MyGame : AdventureGame
    {
        //Actor act;
        //Line lin;
                
        //public static Image imForest2 = Image.FromFile(@"Sprites\лес2.png");
        //public static Image imForest3 = Image.FromFile(@"Sprites\лес3.png");
        //public static Image imGhost2 = Image.FromFile(@"Sprites\ghost2.png"); //сильно пугает
        //public static Image imWeepingAngel2 = Image.FromFile(@"Sprites\angel2.png"); //ангел с венком

        public static Sprite sForest1 = new Sprite(Image.FromFile(@"Sprites\лес1.png"));
        public static Sprite sGhost0 = new Sprite(Image.FromFile(@"Sprites\ghost0.png"));
        public static Sprite sGhost1 = new Sprite(Image.FromFile(@"Sprites\ghost1.png"));
        public static Sprite sActorLeft0 = new Sprite(Image.FromFile(@"Sprites\actorleft0.png"));
        public static Sprite sActorRight0 = new Sprite(Image.FromFile(@"Sprites\actorright0.png"));
        //public static Sprite sActorLeft1 = new Sprite(Image.FromFile(@"Sprites\actorleft1.gif"));
        //public static Sprite sActorRight1 = new Sprite(Image.FromFile(@"Sprites\actorright1.gif"));
        public static Sprite sAngel1 = new Sprite(Image.FromFile(@"Sprites\angel1.png"));
        public static Sprite sCrown = new Sprite(Image.FromFile(@"Sprites\crown.png"));
          
        Object ghostObj = new Object(sGhost0);
        Object angelObj = new Object(sAngel1);
        Object crownObj = new Object(sCrown);
        public Actor act = new Actor(new Dictionary<string, Sprite>
            {
                { "Left", sActorLeft0},
                { "Right", sActorRight0},
                //{ "GoLeft", roomForest3},
                //{ "GoRight", roomForest3}
            });
        public MyGame()
        {
            Room roomForest1 = new Room(sForest1, new Line(0, 0, 0, 0));            
            Room roomForest2 = new Room(sForest1, new Line(0, 0, 0, 0));            
            Room roomForest3 = new Room(sForest1, new Line(0, 0, 0, 0));
            CurrentRoom = roomForest1;
            rooms = new Dictionary<string, Room>
            {
                { "ForestStart", roomForest1},
                { "ForestGraveyard", roomForest2},
                { "ForestFox", roomForest3}
            };
            roomForest1.objects.Add(ghostObj);
            roomForest1.objects.Add(crownObj);
            roomForest1.objects.Add(act);
            PlaceObject(ghostObj, 200, 450);
            PlaceObject(angelObj, 600, 200);
            PlaceObject(act, 600, 200);
            CurrentRoom.Update();
            SetRoom(roomForest1);
            
        }
            
    }
}
