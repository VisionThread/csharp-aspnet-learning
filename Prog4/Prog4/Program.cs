using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    internal class Program
    {
        public static void Main()
        {
            Program p = new Program();   //static method
            //p.Even();
            //Program.Odd();
            int i = 3;
            Console.WriteLine(i);
            Program.Simple(ref i);
            Console.WriteLine(i);
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------\n");
            Console.Write("Calculate sum,product, string in one function using out parameter");

            int s = 0;
            int pr = 0;
            string h;
            Program.Calc(10, 20, out s, out pr,out h);
            Console.WriteLine("Sum :{0} , Product : {1}, string:{2}",s,pr,h);

            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------\n");
            Console.Write("Give me parameter array\n");
            int[] num = new int[3];
            num[0] = 101;
            num[1] = 102;
            num[2] = 103;
            ParamsMethod(num);
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------\n");
            Console.Write("We can send any int array when param keyword is used\n");
            ParamsMethod(1,2,3,4,5,6,7,8,9,10);
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------\n");
            Console.Write("We can send any stringarray when param keyword is used\n");
            Param2("apple", "cherry", "banana");
        }

        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine("there are {0} elements  ",Numbers.Length);
           foreach(int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }
        public static void Param2(params string[] fruits)
        {
            Console.WriteLine("there are {0} elements  ", fruits.Length);
            foreach (string f in fruits)
            {
                      Console.WriteLine(f);
            }
        }

        public static void Calc(int fn, int ln, out int Sum, out int Prod,out string h)
        {
            Sum = fn + ln;
            Prod = fn * ln;
            h = "Hello Smruti";
        }

        public  void Even()
        {
            int s = 0;
            while(s<=20)
            {
                Console.WriteLine(s);  //instance method
                s += 2;
            }
        }

        public static void Odd()
        {
            int s = 1;
            while (s <= 20)
            {
                Console.WriteLine(s);  // another static  method
                s += 2;
            }
        }

        public static void Simple( ref int j)
        {
            j = 101;
           
        }

       
    }
}
