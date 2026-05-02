using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outputFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int result;

            result = num1 + num2;
            result = num1 - num2;

            // Now we dont want to print just result we want to print like this (10+20=30)
            Console.WriteLine($"{num1}+{num2}={result}");
            Console.WriteLine($"{num1}-{num2}={result}");

            //String Formating 
            int val1 = 2;
            int val2 = 4;
            int solution;
            solution = val1 + val2;
            Console.WriteLine("{0} + {1}= {2}", val1, val2, solution);

            Console.ReadLine();
        }
    }
}
