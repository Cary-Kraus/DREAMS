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
            new Animation(new List<string>() { @"Sprites\actorleft11.png",
                @"Sprites\actorleft12.png"}),
            new Animation(new List<string>() { @"Sprites\actorright11.png",
                @"Sprites\actorright12.png"}))
        {            

        }
    }
}
