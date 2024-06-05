using System.Drawing;
using System.Collections.Generic;
using System.Linq;

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
        static List<Sprite> currentSprites = new List<Sprite>();
        static List<Sprite> allSprites = new List<Sprite>();

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
            currentSprites.Add(sprite);
        }
        public static void ChangeSprite(Sprite sprite1, Sprite sprite2)
        {           
            if (currentSprites.Contains(sprite1) && allSprites.Contains(sprite2))
            {
                foreach (Sprite sprite in currentSprites)
                {
                    if (sprite.Equals(sprite1))
                    {
                        currentSprites[currentSprites.IndexOf(sprite)].img = sprite2.img;
                    }
                }                
            }                      
        }
        static void DelSprite(Sprite sprite)
        {
            currentSprites.Remove(sprite);
        }
        static void DelAll()
        {
            currentSprites.RemoveRange(0, currentSprites.Count());
        }
        public static void UpdateGraphics(Graphics g)
        {
            g.Clear(Color.Black);
            foreach (var sprite in currentSprites)
            {                
                g.DrawImage(sprite.img, sprite.x, sprite.y);
            }
        }
        public static void AddToAllSprites(Sprite sprite)
        {
            allSprites.Add(sprite);
        }
    }
}
