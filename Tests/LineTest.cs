using AdventureEngine;
using System.Drawing;

namespace Tests
{
    [TestClass]
    public class LineTest
    {       
        Line line1 = new Line(10, 20, 10, 10);

        [TestMethod]
        public void LineOutLine1()
        {
            Assert.IsTrue(line1.IsInside(new Line(10, 20, 2, 2)));
        }

        [TestMethod]
        public void LineOutLine2()
        {
            Assert.IsFalse(line1.IsInside(new Line(5, 15, 10, 10)));
        }

        [TestMethod]
        public void LineOutLine3()
        {
            Assert.IsFalse(line1.IsInside(new Line(1, 5, 10, 10)));
        }

        [TestMethod]
        public void LineOutLine33()
        {
            Assert.IsFalse(line1.IsInside(new Line(21, 25, 10, 10)));
        }

        [TestMethod]
        public void LineTouchLeft()
        {
            Assert.IsFalse(line1.IsInside(new Line(1, 10, 10, 10)));
        }

        [TestMethod]
        public void LineTouchRight()
        {
            Assert.IsFalse(line1.IsInside(new Line(20, 30, 10, 10)));
        }

        [TestMethod]
        public void LineCrossLeft()
        {
            Assert.IsFalse(line1.IsInside(new Line(5, 15, 10, 10)));
        }

        [TestMethod]
        public void LineCrossRight()
        {
            Assert.IsFalse(line1.IsInside(new Line(15, 25, 10, 10)));
        }

        [TestMethod]
        public void LineInsideLine()
        {
            Assert.IsFalse(line1.IsInside(new Line(1, 25, 10, 10)));
        }
    }
}