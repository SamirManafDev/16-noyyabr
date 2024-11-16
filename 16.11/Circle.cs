using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._11
{

    class Circle : Shape
    {
        public double Radius { get; set; }
        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
