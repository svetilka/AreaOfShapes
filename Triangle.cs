using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaOfShapes.Interface;

namespace AreaOfShapes
{
    public class Triangle: IShape
    {
        double _side1;
        double _side2;
        double _side3;
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 < 0)
                throw new ArgumentOutOfRangeException("side1");

            if (side2 < 0)
                throw new ArgumentOutOfRangeException("side2");

            if (side3 < 0)
                throw new ArgumentOutOfRangeException("side3");

            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        private double Semiperimeter()
        {
            var result =  1 / 2 * (_side1 + _side2 + _side3);
            Console.WriteLine($"Semiperimeter = {result}");
            return result;
        }

        public double Area()
        {
            var semiperimeter = Semiperimeter();
            return Math.Sqrt(semiperimeter * (semiperimeter - _side1) * (semiperimeter - _side2) * (semiperimeter - _side3));
        }
    }
}
