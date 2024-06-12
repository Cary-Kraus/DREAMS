using AdventureEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DREAMS
{
    internal class Ghost : Object
    {
        //ClickScript clickScript;

        public Ghost() : base(new Sprite(@"Sprites\ghost\stay\1.png"))
        {
            Animation stay = new Animation(new List<string>(){ @"Sprites\ghost\stay\1.png", @"Sprites\ghost\stay\2.png", @"Sprites\ghost\stay\3.png", @"Sprites\ghost\stay\4.png" });
            Animation scary = new Animation(new List<string>(){ @"Sprites\ghost\scare\1.png", @"Sprites\ghost\scare\2.png", @"Sprites\ghost\scare\3.png", @"Sprites\ghost\scare\4.png" });
            Animation veryScary = new Animation(new List<string>(){ @"Sprites\ghost\very scare\1.png", @"Sprites\ghost\very scare\2.png", @"Sprites\ghost\very scare\3.png", @"Sprites\ghost\very scare\4.png" });
            states = new Dictionary<string, Sprite>()
            {
                { "Stay", stay },
                { "Scary", scary },
                {"VeryScary", veryScary }
            };
            currentState = "Stay";
            sprite = states["Stay"];
        }
        public override void StartScriptClick()
        {
            VeryScare();
        }
        public void Scare()
        {
            SetState("Scary");
        }
        public void VeryScare()
        {
        //вычислить динамически, используя размер и координаты стандартного спрайта
            x = 130;
            y = 10;
            z = 19;
            SetState("VeryScary");
        }
    }
}
