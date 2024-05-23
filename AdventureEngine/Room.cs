using AdventureEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DREAMS
{
    public class Room : Object
    {
        Sprite sprite;
        Line line;
        public Room(Sprite sprite, Line line) : base(sprite, line)
        {
            this.line = line;
            this.sprite = sprite;
        }
    }
}
