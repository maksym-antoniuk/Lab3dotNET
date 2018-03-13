using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class CircleTask6 : Figure
    {
        double r;
        public CircleTask6() { r = 0; }
        public CircleTask6(point p, double r) { center = p; this.r = r; }
        public void Draw()
        {
            Console.WriteLine("Представьте что здесь нарисован круг");
        }
    }
}
