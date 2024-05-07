using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DREAMS;

namespace AdventureEngine
{
    /// <summary>
    /// Этот класс управляет графикой и выводимыми изображениями (спрайтами).
    /// Поля: коэффициент масштабирования - позволяет менять масштаб всех спрайтов
    /// Методы: Добавить спрайт, Поменять спрайт, Удалить спрайт, 
    ///         Добавить все спрайты (Обновить графику), Удалить все спрайты (Очистить поле).
    /// </summary>
    internal static class GraphicsManager      
    {
        static double scalling_coef; //коэффициент масштабирования
        static List<Sprite> sprites = new List<Sprite>();

        public static List<Sprite> GetAllSprites()
        {
            return sprites;           
        }
        static void AddSprite(Sprite sprite, Graphics g)
        {
            g.DrawImage(sprite.img, sprite.coords);
        }
        static void ChangeSprite(Sprite sprite1, Sprite sprite2, Graphics g)
        {
            //int index1 = sprites.IndexOf(sprite1);
            //int index2 = sprites.IndexOf(sprite2);            
            sprites[sprites.IndexOf(sprite1)] = sprite2;
            sprites[sprites.IndexOf(sprite2)] = sprite1;
            g.DrawImage(sprite1.img, sprite1.coords);
            
        }
        static void DelSprite(Sprite sprite, Graphics g)
        {
            //g.Clear(Color.Black); удаляет все, а нужно конкретный sprite
        }
        static void DelAll(Graphics g)
        {
            g.Clear(Color.Black);
        }
        internal static void DrawAll(Graphics g)
        {
            g.Clear(Color.Black);
            foreach (var sprite in sprites)
            {
                g.DrawImage(sprite.img, sprite.coords);
            }
        }
    }
}
