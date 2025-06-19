using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2
{
    public static class myHelperFunc
    {
        // Extension method to count words in a string
        public static string RightSubstring(this string str,int c)
        {
            return str.Substring(str.Length - c, c);
        }
    }
    internal class Program
    {

        //private static string result;

        //static void Main()
        //{
        //    SaySomething();
        //    Console.WriteLine(result);
        //}

        //static async Task<string> SaySomething()
        //{
        //    await Task.Delay(5);
        //    result = "Hello world!";
        //    return "Something";
        //}

        //Pass by value
        static void Main(string[] args)
        {
            int x, y;
            x = 5; y = 10;
            Console.WriteLine("Orignal:"+x+" " +y);
            PassByValue(x, y);
            Console.WriteLine("After pass by value:" + x + " " +y);
            PassByRef(ref x, ref y);
            Console.WriteLine("After pass by refernece:" + x + " " + y);

            Console.WriteLine("--------------------------------------------------------------------------");
            string str = "hello how are you today";
            string ans = str.RightSubstring(4);
            Console.WriteLine(ans);
        }

        static void PassByValue(int x,int y)
        {
            x = 100;
            y = 200;
        }


        static void PassByRef(ref int x, ref int y)
        {
            x = 100;
            y = 200;
        }


    }
}

//so i got error when something was in inverted quotes 