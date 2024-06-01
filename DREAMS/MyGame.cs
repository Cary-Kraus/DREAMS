using System.Collections.Generic;
using System.Drawing;
using AdventureEngine;

namespace DREAMS
{
    public class MyGame : AdventureGame
    {
        Room roomForest1, roomForest2, roomForest3;
        //Actor act;
        Line lin;
                
        public static Image imForest1 = Image.FromFile(@"Sprites\лес1.png");
        //public static Image imForest2 = Image.FromFile(@"Sprites\лес2.png");
        //public static Image imForest3 = Image.FromFile(@"Sprites\лес3.png");

        public static Image imActorRight0 = Image.FromFile(@"Sprites\actorright0.png"); //стоит вправо
        public static Image imActorLeft0 = Image.FromFile(@"Sprites\actorleft0.png"); //стоит влево
        //public static Image imActorRight1 = Image.FromFile(@"Sprites\actor1.gif"); //анимация ходьбы вправо
        //public static Image imActorLeft1 = Image.FromFile(@"Sprites\actor1.gif"); //анимация ходьбы влево

        public static Image imGhost0 = Image.FromFile(@"Sprites\ghost0.png"); //стоит
        public static Image imGhost1 = Image.FromFile(@"Sprites\ghost1.png"); //пугает
        //public static Image imGhost2 = Image.FromFile(@"Sprites\ghost2.png"); //сильно пугает

        public static Image imWeepingAngel1 = Image.FromFile(@"Sprites\angel1.png"); //ангел без венка
        //public static Image imWeepingAngel2 = Image.FromFile(@"Sprites\angel2.png"); //ангел с венком
        public static Image imCrown = Image.FromFile(@"Sprites\crown.png"); //венок

        public static Sprite sForest1 = new Sprite(imForest1);
        public static Sprite sGhost0 = new Sprite(imGhost0);
        public static Sprite sGhost1 = new Sprite(imGhost1);
        public static Sprite sActorLeft0 = new Sprite(imActorLeft0);
        public static Sprite sActorRight0 = new Sprite(imActorRight0);
        //Sprite sActorLeft1 = new Sprite(imActorLeft1);
        //Sprite sActorRight1 = new Sprite(imActorRight1);
        public static Sprite sAngel1 = new Sprite(imWeepingAngel1);
        public static Sprite sCrown = new Sprite(imCrown);
          
        Object ghostObj = new Object(sGhost0);
        Object angelObj = new Object(sAngel1);
        Object crownObj = new Object(sCrown);
        Actor act = new Actor(sActorLeft0);
        public MyGame()
        {
            Room roomForest1 = new Room(sForest1, new Line(0, 0, 0, 0));            
            Room roomForest2 = new Room(sForest1, new Line(0, 0, 0, 0));            
            Room roomForest3 = new Room(sForest1, new Line(0, 0, 0, 0));  
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
