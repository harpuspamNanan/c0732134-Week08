using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0732134_Week08
{
    class Program
    {

        public delegate string MyDelegate(int argument1, int argument2);            // A type of method, which can be paeesd around just like a variable

        static string func1(int a, int b)
        {
            return (a + b).ToString();
        }

        static string func2(int a, int b)
        {
            return (a * b).ToString();
        }

        static void Main(string[] args)
        {
            
        }
    }
}
