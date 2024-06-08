using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureEngine
{
    public class Line
    {
        public int x1;
        public int x2;
        public int y1;
        public int y2;

        public Line(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        public bool IsInside(Line lin)
        {
            return lin.x1 >= x1 && lin.x2 <= x2;
        }

        public bool IsOnTarget(Line lin)
        {
            return true;
        }
    }
}
