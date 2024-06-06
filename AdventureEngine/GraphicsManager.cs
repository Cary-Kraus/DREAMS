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

        /// <summary>
        /// Добавляет sprite в список, сохраняя переданные координаты.
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
        /// <summary>
        /// Меняет sprite1 в текущем списке на sprite2 из общего списка
        /// </summary>
        /// <param name="sprite1"></param>
        /// <param name="sprite2"></param>
        public static void ChangeSprite(Sprite sprite1, Sprite sprite2)
        {                                
            currentSprites[currentSprites.IndexOf(sprite1)].img = sprite2.img;
        }
        /// <summary>
        /// Удаляет спрайт из списка текущих спрайтов
        /// </summary>
        /// <param name="sprite"></param>
        static void DelSprite(Sprite sprite)
        {
            currentSprites.Remove(sprite);
        }
        /// <summary>
        /// Очищает весь список текущих спрайтов
        /// </summary>
        static void DelAll()
        {
            currentSprites.RemoveRange(0, currentSprites.Count());
        }
        /// <summary>
        /// Перебирает все текущие спрайты и перерисовывает по их координатам
        /// </summary>
        /// <param name="g"></param>
        public static void UpdateGraphics(Graphics g)
        {
            g.Clear(Color.Black);
            foreach (var sprite in currentSprites)
            {                
                g.DrawImage(sprite.img, sprite.x, sprite.y);
            }
        }
    }
}
