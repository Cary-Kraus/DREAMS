using AdventureEngine;
using System.Collections.Generic;

namespace DREAMS
{
    public class Object
    {
        public Sprite sprite;
        public int x;
        public int y;
        public Dictionary<string, Sprite> states = new Dictionary<string, Sprite>();
        public string currentState;


        public Object(Sprite s)
        {
            sprite = s;
            currentState = "default";
        }
        public Object()
        {
            
        }
        public virtual void Update()
        {
        }

        public void SetStates(string state)
        {
            if (currentState != state)
            {
                currentState = state;
                if (states.ContainsKey(currentState))
                    sprite = states[currentState];
            }            
        }
        public virtual void Stop()
        {

        }
    }
}
