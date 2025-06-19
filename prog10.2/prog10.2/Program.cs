using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//multicast delegates

public delegate void Sampledel();
//ques Write a program with a multicast delegate that calls two methods: one to print "Hello" and another to print "World".

public delegate void Sample2();

public delegate int Sample3();
namespace prog10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sampledel d1, d2, d3, d4;
            d1 = new Sampledel(Func1);
            d2 = new Sampledel(Func2);
            d3 = new Sampledel(Func3);

            d4 = d1 + d2 + d3;
            d4();
            //now since we are only invoking d4 delegate since its pointing to d1,d2,d3 ,so all d1,d2,d3 will be invoked 
            //so Func1,Func2,Func3 will be executed from above so d4 is nulticast delegate
            //now to remove any delegate use '-' sign
            //version 2
            Sampledel d5 = new Sampledel(Func1);
            //now i want d5 to point to func1 and as well as func3
            d5 += Func3;
            d5-=Func1;
            d5();

            Sample2 d6 = new Sample2(S1);
            d6 += S2;
            d6();

            Sample3 d7 = new Sample3(Func4);
            d7 += Func5;
            int y = d7();
            Console.WriteLine(y);
            //if the delegate has return type other than void and if delegate is a multicast delegate only the last 
            //invoked method will be returned , along the same way if out parameter is used then values of last method will be assigned
            //since int y can hold one values so last method which delegates point at is returned
        }


        public static void S1()
        {
            Console.WriteLine("Hello");
        }

        public static void S2()
        {
            Console.WriteLine("World");
        }
        public static void Func1()
        {
            Console.WriteLine("Sample method 1 is invoked...");
        }
        public static void Func2()
        {
            Console.WriteLine("Sample method 2 is invoked...");
        }
        public static void Func3()
        {
            Console.WriteLine("Sample method 3 is invoked...");
        }

        public static int Func4()
        {
            return 10;
        }

        public static int Func5()
        {
            return 2;
        }
    }
}
