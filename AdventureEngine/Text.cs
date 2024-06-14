using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.IO;

namespace AdventureEngine
{
    public class Text : Object
    {
        public string text;
        //public int x;
        //public int y;
        PrivateFontCollection fontCollection = new PrivateFontCollection();
        public Font font;
        public Brush brush;
        public string[] texts;
        int cur_text = 0;

        public Text(string text)
        {            
            this.text = text;
            //this.x = x;
            //this.y = y;
            fontCollection.AddFontFile("Fifaks.ttf"); // файл шрифта
            FontFamily family = fontCollection.Families[0];
            font = new Font(family, 22);
            brush = new SolidBrush(Color.Plum);
            sprite = new Sprite(@"Sprites\диалоговое окно.png");
        }
        /// <summary>
        /// Меняет текст на следующий в списке
        /// </summary>
        public override void StartScriptClick()
        {
            //при каждом вызове этого метод текущий текс должен меняться на след.
            //меняем текущий текст. на след. в массиве
            text = GetTextFromFile(cur_text++);

        }
        /// <summary>
        /// Возвращает строку формата Text из файла по индексу
        /// </summary>
        /// <param name="numberOfText">Индекс</param>
        /// <returns></returns>
        public static string GetTextFromFile(int numberOfText)
        {
            string filePath = @"Texts\TextFile1.txt";
            string lineToReturn = null;

            string[] lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                // Если строка начинается с искомого номера и точки, сохраняем её
                if (line.StartsWith(numberOfText + "."))
                {
                    lineToReturn = line.Substring(line.IndexOf(' ') + 1);
                    break;
                }
            }

            if (lineToReturn == "")
                Console.WriteLine($"Текст под номером {numberOfText} не найден");
            return lineToReturn;
        }
    }
}
