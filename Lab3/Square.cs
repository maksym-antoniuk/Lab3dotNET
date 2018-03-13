using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Square
    {
        protected double a;
        public double A
        {
            get { return a; }
            set
            {
                if (value < 0) throw new NegativeException(NegativeException.error);
                a = value;
            }
        }

        public Square() { }

        public Square(double a)
        {
            this.a = a;
        }

        public virtual double perimeter()
        {
            return a * 4;
        }
    }
}
