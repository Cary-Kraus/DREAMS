using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Security.Policy;

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
            //Console.WriteLine($"Спрайт {sprite} добавлен в список спрайтов");
        }
        public static void ChangeSprite(Sprite sprite1, Sprite sprite2)
        {
            if (!sprites.Contains(sprite1))
                Console.WriteLine($"{sprite1.name} не найден в sprites");
            if (!sprites.Contains(sprite2))
                Console.WriteLine($"{sprite2.name} не найден в sprites");
            sprites[sprites.IndexOf(sprite1)] = sprite2;

            Console.WriteLine($"Индекс спрайта {sprite1.name} = {sprites.IndexOf(sprite1)}");
            Console.WriteLine($"Индекс спрайта {sprite2.name} = {sprites.IndexOf(sprite2)}");            
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
            //Console.WriteLine("Обновление графики");
            g.Clear(Color.Black);
            foreach (var sprite in sprites)
            {
                g.DrawImage(sprite.img, sprite.x, sprite.y);
            }
        }
    }
}
