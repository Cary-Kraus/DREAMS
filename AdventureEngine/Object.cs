using AdventureEngine;
using System.Collections.Generic;

namespace DREAMS
{
    public class Object
    {
        public Sprite sprite;
        public int x;
        public int y;
        public int z;
        public int width;
        public int height;
        public Dictionary<string, Sprite> states = new Dictionary<string, Sprite>();
        public string currentState;
        public Line selfLine;
        public delegate void InsideScript();
        public delegate void ClickScript();
        public InsideScript insideScript = null;
        public ClickScript clickScript = null;
        public bool present = true;
        public bool clicked = false;

        public Object(Sprite s)
        {
            sprite = s;
            z = 0;
            currentState = "default";
            selfLine = new Line(sprite.x, sprite.x + sprite.img.Width, sprite.y, sprite.y - sprite.img.Height);
            width = sprite.size.Width;
            height = sprite.size.Height;
        }
        
        /// <summary>
        /// Обновляет координты спрайта и линии объекта 
        /// </summary>
        public virtual void Update()
        {
            sprite.x = x;
            sprite.y = y;
            sprite.z = z;
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
                sprite = states[currentState];
            }               
        }
        
        public virtual void Stop()
        {

        }
        public void StartScriptClick()
        {
            if (!clicked)
                clicked = true;
            x = x + 10;
            y = y + 10;

        }
    }
}
