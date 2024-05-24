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

        public static int cursorX;
        public static int cursorY;
        //protected int speed_x, speed_y;

        public Actor(Sprite s) : base(s)
        {
            sprite = s;
        }
        public override void Update() //обновление координат объекта. Если раскомментировать - будет двигаться
        {
            //x += speed_x;
            //y += speed_y;
            //sprite.x = x;
            //sprite.y = y;
        }
        /// <summary>
        /// Меняет вектор движения персонажа к месту клика мыши
        /// </summary>
        /// <param name="mouseX"></param>
        /// <param name="mouseY"></param>
        public static void CalcDistnc(int mouseX, int mouseY)
        {
            //проверка на нахождение внутри области движения
            //вычисление расстояния от персонажа до мыши
            //вычисление значений векторов движения к месту клика
        }
        public void MoveUp() //движение вверх
        {
            y--;
            sprite.y = y;
        }
        public void MoveDown() //движение вниз
        {
            y++;
            sprite.y = y;
        }
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
