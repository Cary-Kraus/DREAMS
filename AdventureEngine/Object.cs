using AdventureEngine;
using System.Collections.Generic;

namespace AdventureEngine
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
        /// <summary>
        /// флаг присутствия объекта в комнате
        /// </summary>
        public bool present = true;
        /// <summary>
        /// флаг отображения объекта
        /// </summary>
        public bool visible = true;

        public Object(Sprite s, int width = 0, int height = 0)
        {
            sprite = s;
            z = 0;
            currentState = "default";
            this.visible = s != null;
            if (visible)
            {
                selfLine = new Line(sprite.x, sprite.x + sprite.img.Width, sprite.y, sprite.y - sprite.img.Height);
                this.width = sprite.img.Width;
                this.height = sprite.img.Height;
            } 
            else
            {
                this.width = width;
                this.height = height;
                selfLine = new Line(0, 0, width, 0);
            }
        }

        public virtual void PickUpObject(Object obj)
        {

        }

        /// <summary>
        /// Обновляет координты спрайта и линии объекта 
        /// </summary>
        public virtual void Update()
        {
            if (visible)
            {
                sprite.x = x;
                sprite.y = y;
                sprite.z = z;
            }
            selfLine.x1 = x;
            selfLine.x2 = selfLine.x1 + width;
            selfLine.y1 = y;
            selfLine.y2 = y;
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
        public virtual void StartScriptClick()
        {
            //if (!clicked)
            //    clicked = true;
            //x = x + 10;
            //y = y + 10;
        }
    }
}
