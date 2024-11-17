using System;
using AreaOfShapes;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapesTests.TestCases
{
    [TestClass]
    public class RightTriangleTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IList<double> sides = new List<double> { 10, 6, 8 };

            Triangle triangle = new Triangle(sides);
        
            Assert.IsTrue(triangle.IsRightTriangle());
        }

        [TestMethod]
        public void TestMethod2()
        {
            IList<double> sides = new List<double> { 2, 3, 5 };

            Triangle triangle = new Triangle(sides);

            Assert.IsFalse(triangle.IsRightTriangle());
        }
    }
}
