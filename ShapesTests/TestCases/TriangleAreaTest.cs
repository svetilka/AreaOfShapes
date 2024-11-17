using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaOfShapes;
using System.Security.Principal;
using System.Collections.Generic;

namespace ShapesTests
{
    [TestClass]
    public class TriangleAreaTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IList<double> sides = new List<double> { 3, 4, 5 };
            double expected = 6;

            Triangle triangle = new Triangle(sides);
            double actual = triangle.Area();
            Console.WriteLine($"Area of triangle = {actual}");
            Assert.AreEqual(expected, actual, 0.1, "The area of ​​the triangle is calculated incorrectly");
        }
    }
}
