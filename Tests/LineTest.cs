using AdventureEngine;
using System.Drawing;

namespace Tests
{
    [TestClass]
    public class LineTest
    {       
        //public void TestLine(Line l1, Line l2)
        //{
        //    bool b; //костыль
        //    bool t = false; //костыль
        //    // нужно ли вычислять и сравнивать расстояние???????
        //    double linLenth = Math.Sqrt(Math.Pow(l1.x2 - l1.x1, 2.0) + 1); //длина линии lin
        //    double thisLenth = Math.Sqrt(Math.Pow(l2.x2 - l2.x1, 2.0) + 1); //длина текущей линии
        //    if (linLenth - thisLenth >= 0 && l1.y == l2.y)
        //        if (l2.x1 - l1.x1 > 0 && l2.x2 - l1.x2 < 0)
        //            b = true;
        //        else b = false;
        //    else b = false;
        //    Assert.AreEqual(t, b);
        //}
        Line line1 = new Line(10, 20, 10, 10);

        [TestMethod]
        public void LineOutLine1()
        {
            line1.IsInside(new Line(10, 20, 2, 2));
        }

        [TestMethod]
        public void LineOutLine2()
        {
            line1.IsInside(new Line(5, 15, 10, 10));
        }

        [TestMethod]
        public void LineOutLine3()
        {
            line1.IsInside(new Line(1, 5, 10, 10));
        }

        [TestMethod]
        public void LineTouchLeft()
        {
            line1.IsInside(new Line(1, 10, 10, 10));
        }

        [TestMethod]
        public void LineTouchRight()
        {
            line1.IsInside(new Line(20, 30, 10, 10));
        }

        [TestMethod]
        public void LineCrossLeft()
        {
            line1.IsInside(new Line(5, 15, 10, 10));
        }

        [TestMethod]
        public void LineCrossRight()
        {
            line1.IsInside(new Line(15, 25, 10, 10));
        }

        [TestMethod]
        public void LineInsideLine()
        {
            line1.IsInside(new Line(5, 25, 10, 10));
        }
    }
}