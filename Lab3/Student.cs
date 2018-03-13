using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Student
    {
        private string name;
        private int course;
        private bool grant;

        public Student(string n, int c, bool g)
        {
            name = n;
            course = c;
            grant = g;
        }

        public Student(string n, int c)
        {
            name = n;
            course = c;
        }

        public Student(string n, bool g)
        {
            name = n;
            grant = g;
        }

    }
}
