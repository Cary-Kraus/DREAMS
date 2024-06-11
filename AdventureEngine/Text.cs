using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;

namespace AdventureEngine
{
    public class Text : Object
    {
        public string text;
        public int x;
        public int y;
        PrivateFontCollection fontCollection = new PrivateFontCollection();
        public Font font;
        public Brush brush;


        public Text(string text, int x, int y)
        {
            this.text = text;
            this.x = x;
            this.y = y;
            fontCollection.AddFontFile("Fifaks.ttf"); // файл шрифта
            FontFamily family = fontCollection.Families[0];
            font = new Font(family, 22);
            brush = new SolidBrush(Color.Plum);
        } 
    }
}
