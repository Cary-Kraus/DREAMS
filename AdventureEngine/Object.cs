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
        public Line selfLine;
        public delegate void InsideScript();
        public InsideScript insideScript = null;
        public bool present = true;

        public Object(Sprite s)
        {
            sprite = s;
            currentState = "default";
            selfLine = new Line(sprite.x, sprite.x + sprite.img.Width, sprite.y, sprite.y - sprite.img.Height);
        }
        public virtual void Update()
        {
            sprite.x = x;
            sprite.y = y;
            selfLine.x1 = sprite.x;
            selfLine.x2 = selfLine.x1 + sprite.img.Width;
            selfLine.y1 = sprite.y;
            selfLine.y2 = sprite.y;
        }
        /// <summary>
        /// Меняет текущее состояние объекта на новое,
        /// затем меняет спрайт объекта в соответствии с новым состоянием
        /// </summary>
        /// <param name="state"></param>
        public void SetState(string state)
        {
            if (states.ContainsKey(currentState) && currentState != state)
            {                
                currentState = state;
                GraphicsManager.ChangeSprite(sprite, states[currentState]);
                sprite = states[currentState];//поменять спрайт
            }               
        }
        public virtual void Stop()
        {

        }
    }
}
