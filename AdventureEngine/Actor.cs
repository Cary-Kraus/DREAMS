using AdventureEngine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DREAMS
{
    public class Actor : Object
    {
        const int SPEED_X = 5;
        public static int MaxX;
        public int speed_x;
        public int speed_y;
        public Line selfLine;

        public Actor(Sprite s) : base(s)
        {
            sprite = s;
            selfLine = new Line(s.x, s.x, s.y, s.y - s.img.Height);
        }
        public override void Update() //обновление координат объекта. Если раскомментировать - будет двигаться
        {
            x += speed_x;
            y += speed_y;
            sprite.x = x;
            sprite.y = y;
        }
        /// <summary>
        /// Вычисляет значения векторов в направлении щелчка мыши
        /// </summary>
        /// <param name="mouseX"></param>
        /// <param name="mouseY"></param>
        
        
        /// <summary>
        /// Проверяет, достиг ли гг нужной точки. Если да, то останавливает.
        /// </summary>

        public void MoveLeft() //движение влево
        {
            x -= SPEED_X;
            SetStates(new Dictionary<string, Sprite>
            {
                {"GoLeft", sprite.img = imActorLeft0}
            });
            //sprite.img = MyGame.imActorLeft0;
        }
        public void MoveRight() //движение вправо
        {
            x += SPEED_X;
            SetStates(new Dictionary<string, Sprite>
            {
                {"GoRight", sprite.img = imActorLeft0}
            });
            //sprite.img = MyGame.imActorRight0;
        }
        public void Stop()
        {
            x = 0;
            y = 0;
        }
    }
}
