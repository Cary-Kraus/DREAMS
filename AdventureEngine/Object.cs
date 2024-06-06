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
            sprite.x = x;
            sprite.y = y;
        }
        /// <summary>
        /// Меняет текущее состояние объекта на новое,
        /// затем меняет спрайт объекта в соответствии с новым состоянием
        /// </summary>
        /// <param name="state"></param>
        public void SetStates(string state)
        {
            if (currentState != state)
            {                
                currentState = state;
                if (states.ContainsKey(currentState))
                {
                    GraphicsManager.ChangeSprite(sprite, states[currentState]);
                    //sprite = states[currentState];//поменять спрайт
                }
            }               
        }
        public virtual void Stop()
        {

        }
    }
}
