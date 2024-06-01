using AdventureEngine;
using System.Collections.Generic;

namespace DREAMS
{
    public class Object
    {
        public Sprite sprite;
        public int x;
        public int y;
        public Dictionary<string, Sprite> states;

        public Object(Sprite s)
        {
            sprite = s;
        }
        public Object(Sprite s, Line line)
        {
            sprite = s;
        }
        public virtual void Update()
        {
        }

        public void SetStates(Dictionary<string, Sprite> states)
        {
            this.states = states;
        }
        public virtual void Stop()
        {

        }
    }
}
