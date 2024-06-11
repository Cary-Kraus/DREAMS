using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureEngine;

namespace DREAMS
{
    internal class Girl : Actor
    {

        public Girl() : base(
            new Animation(new List<string>() {
                @"Sprites\act\stay\left\1.png",
                @"Sprites\act\stay\left\2.png",
                @"Sprites\act\stay\left\3.png",
                @"Sprites\act\stay\left\4.png",
                @"Sprites\act\stay\left\5.png",
                @"Sprites\act\stay\left\6.png"}),
            new Animation(new List<string>() {
                @"Sprites\act\stay\right\1.png",
                @"Sprites\act\stay\right\2.png",
                @"Sprites\act\stay\right\3.png",
                @"Sprites\act\stay\right\4.png",
                @"Sprites\act\stay\right\5.png",
                @"Sprites\act\stay\right\6.png"}),
            new Animation(new List<string>() {
                @"Sprites\act\go\left\1.png",
                @"Sprites\act\go\left\2.png",
                @"Sprites\act\go\left\3.png",
                @"Sprites\act\go\left\4.png",
                @"Sprites\act\go\left\5.png",
                @"Sprites\act\go\left\6.png",
                @"Sprites\act\go\left\7.png",
                @"Sprites\act\go\left\8.png"}),
            new Animation(new List<string>() {
                @"Sprites\act\go\right\1.png",
                @"Sprites\act\go\right\2.png",
                @"Sprites\act\go\right\3.png",
                @"Sprites\act\go\right\4.png",
                @"Sprites\act\go\right\5.png",
                @"Sprites\act\go\right\6.png",
                @"Sprites\act\go\right\7.png",
                @"Sprites\act\go\right\8.png"}))
        {
            //
        }
            
        public void MeetGhost()
        {

        }
    }
}
