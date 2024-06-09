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
            new Animation(new List<string>() { @"Sprites\act\stay\left\1.png",
                                                @"Sprites\act\stay\left\2.png",
                                                @"Sprites\act\stay\left\3.png",
                                                @"Sprites\act\stay\left\4.png"}),
            new Animation(new List<string>() { @"Sprites\act\stay\right\1.png",
                                                @"Sprites\act\stay\right\2.png",
                                                @"Sprites\act\stay\right\3.png",
                                                @"Sprites\act\stay\right\4.png"}))
            {            

        }
        public void MeetGhost()
        {

        }
    }
}
