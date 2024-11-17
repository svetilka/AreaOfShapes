using System;
using AreaOfShapes.Interface;

namespace AreaOfShapes
{
    public class Circle : IShape
    {
        private double _radius;
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("radius"); ;

            _radius = radius;
        }
        public double Area()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}