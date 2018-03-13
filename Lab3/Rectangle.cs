using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Rectangle
    {
        point a;
        point b;

        public Rectangle(point a, point b)
        {
            if (a.x < b.x || a.y < b.y)
                throw new Exception();
            this.a = a; this.b = b;
        }
        public override string ToString()
        {
            return "Точка А (" + a.x + "; " + a.y + ") \nТочка В (" + b.x + "; " + b.y + ") ";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Rectangle rec = obj as Rectangle;
            if ((System.Object)rec == null)
                return false;
            return (a.x == rec.a.x) && (b.x == rec.b.x) && (a.y == rec.a.y) && (b.y == rec.b.y);
        }

        public override int GetHashCode()
        {
            int result = 1;
            result += 31 * result + (int)a.x;
            result += 31 * result + (int)a.y;
            result += 31 * result + (int)b.x;
            result += 31 * result + (int)b.y;
            return result;
        }
    }
}
