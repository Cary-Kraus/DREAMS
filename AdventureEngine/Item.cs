using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureEngine;

namespace AdventureEngine
{
    public class Item : Object
    {
        public bool locked = false;

        public Item(Sprite s) : base(s)
        {

        }
        public void PickUp() //подобрать в инвентарь
        {

        }
        public void GiveAway() //отдать
        {

        }
        public void Use() //использовать предмет, после чего но пропадает
        {

        }
    }
}
