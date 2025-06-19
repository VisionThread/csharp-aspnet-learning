using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a delegate that takes a string and prints it in uppercase using an anonymous function.


public delegate void toModify(string s);

//Create a delegate that calculates the square of a number using a lambda expression.
public delegate void toSquare(int a);

namespace prog10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string to modify in various way.");
            string str=Console.ReadLine();
            toModify del1 = new toModify(Uppercase);
            del1(str);
            toModify del2 = new toModify(Lowercase);
            del2(str);
            //now  using lamda expression
            toModify del3= s => Console.WriteLine(s.ToUpper());
            del3(str);
            //now using anonymous function
            toModify del6 = delegate (string msg)
            {
               Console.WriteLine(msg.ToUpper())
                ; };
            del6("keep going, have some patience, be tension free now !");


            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("\nCreate a delegate that calculates the square of a number using a lambda expression.\nEnter number to get its square.");
            int b=int.Parse(Console.ReadLine());
            toSquare del4 = x => Console.WriteLine(x*x);
            del4(b);

            toSquare del5 = x => Console.WriteLine(10 * x);
            del5(b);


        }

        public static void Uppercase(string str)
        {
            string str1 =str.ToUpper();
            Console.WriteLine(str1);
        }

        public static void Lowercase(string str)
        {
           string str1=str.ToLower();
            Console.WriteLine(str1);
        }
     
    }
}
