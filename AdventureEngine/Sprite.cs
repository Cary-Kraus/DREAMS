﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureEngine
{
    public class Sprite : Object
    {
        public Image img;
        public Size size;
        public double x;
        public double y;

        public Sprite(Image image)
        {
            img = image;
            x = 0;
            y = 0;
        }
        public Sprite(string imagePath, int width, int height)
        {
            
            x = 0;
            y = 0;
            size = new Size(width, height);
            img = Image.FromFile(imagePath);
            
            
        }
    }
}
