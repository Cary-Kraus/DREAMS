using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureEngine
{
    /// <summary>
    /// Этот класс управляет графикой и выводимыми изображениями (спрайтами).
    /// Поля: коэффициент масштабирования - позволяет менять масштаб всех спрайтов
    /// Методы: Добавить спрайт, Поменять спрайт, Удалить спрайт, 
    ///         Добавить все спрайты (Обновить графику), Удалить все спрайты (Очистить поле).
    /// </summary>
    public static class GraphicsManager
    {
        static double scalling_coef; //коэффициент масштабирования
        static List<Sprite> sprites = new List<Sprite>();
        //static Graphics g;

        /// <summary>
        /// Добавляет sprite в список. Отображает sprite по координатам x и y.
        /// </summary>
        /// <param name="sprite"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void AddSprite(Sprite sprite, int x, int y)
        {
            sprite.x = x;
            sprite.y = y;
            sprites.Add(sprite);
        }
        static void ChangeSprite(Sprite sprite1, Sprite sprite2)
        {
            sprites[sprites.IndexOf(sprite1)] = sprite2;
            sprites[sprites.IndexOf(sprite2)] = sprite1;
        }
        static void DelSprite(Sprite sprite)
        {
            sprites.Remove(sprite);
        }
        static void DelAll()
        {
            sprites.RemoveRange(0, sprites.Count());
        }
        public static void UpdateGraphics(Graphics g)
        {
            g.Clear(Color.Black);
            foreach (var sprite in sprites)
            {
                g.DrawImage(sprite.img, (float)sprite.x, (float)sprite.y);
            }
        }
    }
}
