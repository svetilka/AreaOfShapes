using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaOfShapes.Interface;

namespace AreaOfShapes
{
    public class Triangle: IAreaShape
    {

        public double AreaOfShapes()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
