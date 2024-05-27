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
        const int MAX_SPEED = 5;
        public static int MaxX;
        public static int MaxY;
        //protected float speed_x, speed_y;

        //public static int cursorX;
        //public static int cursorY;
        //protected int speed_x, speed_y;

        public Actor(Sprite s) : base(s)
        {
            sprite = s;
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
        public void CalcDistnc(int mouseX)
        {  
            double x1 = sprite.x;
            double x2 = sprite.x + sprite.img.Width;
            

            double vx = mouseX - x;
            double vy = 0 - y;
            double dist = Math.Sqrt(vx * vx + vy * vy);
            if (dist >= 5)
            {
                speed_x = (float)(vx / dist * MAX_SPEED);
                speed_y = (float)(vy / dist * MAX_SPEED);
                speed_y = 0;
            }
            else
            {
                speed_x = 0;
                speed_y = 0;
            }

            //проверка на нахождение внутри области движения
            //вычисление расстояния от персонажа до мыши
            //вычисление значений векторов движения к месту клика
        }
        /// <summary>
        /// Проверяет, достиг ли гг нужной точки. Если да, то останавливает.
        /// </summary>
        public void StandHere()
        {

        }
        //public void MoveUp() //движение вверх
        //{
        //    y--;
        //    sprite.y = y;
        //}
        //public void MoveDown() //движение вниз
        //{
        //    y++;
        //    sprite.y = y;
        //}
        public void MoveLeft() //движение влево
        {
            x--;
            sprite.x = x;
        }
        public void MoveRight() //движение вправо
        {
            x++;
            sprite.x = x;
        }
    }
}
