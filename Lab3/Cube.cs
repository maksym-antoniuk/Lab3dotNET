using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Cube : Square
    {
        public Cube() { }
        public Cube(double a) : base(a) { }

        public override double perimeter()
        {
            return 12 * a;
        }
    }
}
