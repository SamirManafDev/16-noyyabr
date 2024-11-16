using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._11
{
    class Rectangle : Shape    
    {
        public double x { get; set; }
        public double y { get; set; }

        public override double GetArea()
        {
            return x * y;
        }
    }
}
