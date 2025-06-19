using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//similar to the class, if you want to create a class u use class keyword,
//similarly to create delegate use delegate
public delegate void func1(string msg);
//Define a delegate called `MathOperation` that takes two integers.
//Create methods for addition, subtraction, multiplication, and division,
//and use the delegate to call these methods.

public delegate void MathOperation(int a, int b);

namespace prog9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            func1 del= new func1(hello);
            del("Hello smruti ,be positive , everything will fall into the place");
            hello("programming you have to complete delegates and exception handling questions aswell");

            MathOperation del1 = new MathOperation(addition);
            MathOperation del2 = new MathOperation(sub);
            MathOperation del3 = new MathOperation(multiplication);
            MathOperation del4 = new MathOperation(division);

            del1(5, 8);
            del2(10, 4);
            del2(8, 1);
            del3(8, 9);
            del4(90, 5);
        }
        public static void hello(string s)
        {
          Console.WriteLine(s);
        }

        public static void addition(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void multiplication(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public static void division(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
