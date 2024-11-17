using AreaOfShapes.Interface;

namespace AreaOfShapes
{
    public class Circle : IAreaShape
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }
        public double AreaOfShapes()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}