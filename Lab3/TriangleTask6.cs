using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class TriangleTask6 : Figure
    {
        point a;
        point b;
        point c;
        public TriangleTask6() { }
        public TriangleTask6(point a, point b, point c, point center)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.center = center;
        }

        public void Draw()
        {
            Console.WriteLine("Представьте что здесь нарисован треугольник");
        }
    }
}
