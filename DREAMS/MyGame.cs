﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using AdventureEngine;

namespace DREAMS
{
    public class MyGame : AdventureGame
    {
                
        public MyGame()
        {
            Room roomForest1, roomForest2, roomForest3;
            Actor act;

            public Dictionary<string, Room> rooms = new Dictionary<int, string>()
            {
                { "Forest", roomForest1},
                { "Cave", roomForest2},
                { "Weald", roomForest3}
            };
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

            Sprite sForest1 = new Sprite(imForest1);
            Sprite sGhost0 = new Sprite(imGhost0);
            Sprite sGhost1 = new Sprite(imGhost1);
            Sprite sActorLeft0 = new Sprite(imActorLeft0);
            Sprite sActorRight0 = new Sprite(imActorRight0);
            //Sprite sActorLeft1 = new Sprite(imActorLeft1);
            //Sprite sActorRight1 = new Sprite(imActorRight1);
            Sprite sAngel1 = new Sprite(imWeepingAngel1);

            Object ghostObj = new Object(sGhost0);
            Object angelObj = new Object(sAngel1);
            act = new Actor(sActorLeft0);
        }
            
    }
}
