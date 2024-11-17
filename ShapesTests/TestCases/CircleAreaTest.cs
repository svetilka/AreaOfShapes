using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaOfShapes;
using System.Security.Principal;

namespace ShapesTests
{
    [TestClass]
    public class CircleAreaTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double radius = 5;
            double expected = 78.5;

            Circle circle = new Circle(radius);
            double actual = circle.Area();
            Assert.AreEqual(expected, actual, 0.1, "The area of ​​the circle is calculated incorrectly");
        }
    }
}
