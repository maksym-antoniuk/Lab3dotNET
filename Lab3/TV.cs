using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class TV
    {
        private int current;

        public TV() { current = 1; }

        public void next()
        {
            current = (current == 100) ? 1 : current + 1;
        }

        public void previous()
        {
            current = (current == 1) ? 100 : current - 1;
        }

        public void setChanel(int chanel)
        {
            if (chanel > 0 && chanel < 101)
                current = chanel;
        }
    }
}
