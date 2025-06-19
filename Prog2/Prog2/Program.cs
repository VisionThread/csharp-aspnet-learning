using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2
{
    internal class Program
    {
        static void Main()
        {
            //integral
            Console.WriteLine("Max = {0} ",int.MaxValue);
            Console.WriteLine("Min = {0} ", int.MinValue);

            //string
            string name = "Smruti";
            Console.WriteLine(name);
            string a = "\"programming\"";
            string b = "i will go by sride.\n i have my s ride at 6:30 pm \n";
            Console.WriteLine(a+b);
            //verbatim literal
            string str = @"C:\\pregim\\dotnet\\training\\smruti";
            Console.WriteLine(str);

            //nullable types

            int? i = null;
        }
    }
}
