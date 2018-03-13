using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class NegativeException : Exception
    {
        public static readonly string error = "Ошибка. Число не может быть положительным!";

        public NegativeException() { }

        public NegativeException(string message) : base(message) { }

        public NegativeException(string message, Exception inner) : base(message, inner) { }
    }
}
