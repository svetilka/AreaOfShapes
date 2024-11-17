using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using AreaOfShapes.Interface;

namespace AreaOfShapes
{
    public class Triangle: IShape
    {
        IList<double> _sides;

        public Triangle(IList<double> sides)
        {
            if (sides.Count != 3) throw new ArgumentOutOfRangeException($"Is not a triangle");

            foreach (var side in sides)
            {
                if (side < 0)
                    throw new ArgumentOutOfRangeException($"side {side}");
            }

            _sides = sides;
        }

        private double Semiperimeter()
        {
            var result = _sides.Sum() / 2;
            Console.Write($"Semiperimeter = {result}");
            return result;
        }

        public double Area()
        {
            var semiperimeter = Semiperimeter();
            return Math.Sqrt(semiperimeter * (semiperimeter - _sides[0]) 
                * (semiperimeter - _sides[1]) * (semiperimeter - _sides[2]));
        }

        public bool IsRightTriangle()
        {
            return false;
        }

    }
}
