using AdventureEngine;
using System.Drawing;

namespace Tests
{
    [TestClass]
    public class LineTest
    {

        //Проверка любых ситуаций,
        //когда текущая линия не находится внутри другой линии
        public void TestLine(Line l1, Line l2)
        {
            bool b; //костыль
            bool t = false; //костыль
            // нужно ли вычислять и сравнивать расстояние???????
            double linLenth = Math.Sqrt(Math.Pow(l1.x2 - l1.x1, 2.0) + 1); //длина линии lin
            double thisLenth = Math.Sqrt(Math.Pow(l2.x2 - l2.x1, 2.0) + 1); //длина текущей линии
            if (linLenth - thisLenth >= 0 && l1.y == l2.y)
                if (l2.x1 - l1.x1 > 0 && l2.x2 - l1.x2 < 0)
                    b = true;
                else b = false;
            else b = false;
            Assert.AreEqual(t, b);
        }

        [TestMethod]
        public void LineOutLine1()
        {
            TestLine(new Line(2, 5, 1), new Line(1, 3, 2));
        }

        [TestMethod]
        public void LineOutLine2()
        {
            TestLine(new Line(2, 5, 3), new Line(1, 3, 2));
        }

        [TestMethod]
        public void LineOutLine3()
        {
            TestLine(new Line(3, 6, 3), new Line(1, 3, 3));
        }

        [TestMethod]
        public void LineTouchLeft()
        {
            TestLine(new Line(1, 3, 2), new Line(3, 6, 2));
        }

        [TestMethod]
        public void LineTouchRight()
        {
            TestLine(new Line(1, 3, 2), new Line(3, 6, 2));
        }

        [TestMethod]
        public void LineCrossLeft()
        {
            TestLine(new Line(2, 6, 2), new Line(1, 3, 2));
        }

        [TestMethod]
        public void LineCrossRight()
        {
            TestLine(new Line(1, 5, 2), new Line(4, 6, 2));
        }

        [TestMethod]
        public void LineInsideLine() //тест не пройден => вариант "линия внутри линии" работает
        {
            TestLine(new Line(1, 6, 2), new Line(2, 4, 2));
        }
    }
}