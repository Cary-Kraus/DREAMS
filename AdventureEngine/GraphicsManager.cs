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
        static List<Sprite> sprites = new List<Sprite>();
        static List<Animation> currentAnimations = new List<Animation>();
        static int tag = 0;

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
            sprites.Add(sprite);
            tag++;
            sprite.tag = tag;
        }
        /// <summary>
        /// Меняет sprite1 в текущем списке на sprite2 из общего списка
        /// </summary>
        /// <param name="sprite1"></param>
        /// <param name="sprite2"></param>
        public static void ChangeSprite(Sprite sprite1, Sprite sprite2)
        {
            int i = sprites.FindIndex((s) => s.tag == sprite1.tag);
            sprites[i] = sprite2;
        }
        /// <summary>
        /// Удаляет спрайт из списка текущих спрайтов
        /// </summary>
        /// <param name="sprite"></param>
        public static void DelSprite(Sprite sprite)
        {
            sprites.Remove(sprite);
        }
        /// <summary>
        /// Очищает весь список текущих спрайтов
        /// </summary>
        public static void DelAll()
        {
            sprites.Clear();
        }
        /// <summary>
        /// Перебирает все текущие спрайты и перерисовывает по их координатам
        /// </summary>
        /// <param name="g"></param>
        public static void UpdateGraphics(Graphics g)
        {
            //сделать рисовку анимации
            g.Clear(Color.Black);
            foreach (var sprite in sprites)
            {
                sprite.Update(); //обновление картинок в анимации
                g.DrawImage(sprite.img, sprite.x, sprite.y);               
            }
        }
    }
}
