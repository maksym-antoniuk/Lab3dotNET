using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public struct point { public double x; public double y; };
    public class Figure
    {
        protected point center;
        public Figure() { center.x = 0; center.y = 0; }
        public Figure(point p) { center = p; }
    }
}
