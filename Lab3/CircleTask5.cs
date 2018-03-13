using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class CircleTask5
    {
        double x;
        double y;
        double r;

        public CircleTask5() { }

        public CircleTask5(double x, double y, double r)
        {
            if (r < 0) throw new NegativeException(NegativeException.error);
            this.x = x;
            this.y = y;
            this.r = r;
        }

        public double lenght()
        {
            return 2 * r * Math.PI;
        }

        public double lenght(double r)
        {
            if (r < 0) throw new NegativeException(NegativeException.error);
            return 2 * Math.PI * r;
        }

        public CircleTask5 getCircle()
        {
            return new CircleTask5(this.x, this.y, this.r);
        }

        public CircleTask5 getCircle(double x, double y, double r)
        {
            return new CircleTask5(x, y, r);
        }

        public bool isOnCircle(double x, double y)
        {
            return Math.Sqrt(Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2)) <= this.r;
        }

        public override string ToString()
        {
            return "Центр(" + x + ";" + y + ") Радиус = " + r;
        }

    }
}
