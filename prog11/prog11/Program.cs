using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that takes two numbers from the user and performs division.
//Use a `try-catch` block to handle a divide-by-zero exception.

namespace prog11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader st1 = null;
            try
            {
                //StreamReader st1 = new StreamReader(@"C:\\Users\\2020677\\OneDrive - Revvity\\Desktop\\Files\\file1.txt");
                  st1 = new StreamReader(@"C:\\Users\\2020677\\OneDrive - Revvity\\Desktop\\Files\\file.txt");
                Console.WriteLine(st1.ReadToEnd());
               // st1.Close();
            }
            catch(FileNotFoundException e)
            {
                Console.Write("Not able to locate this file , please try again :)");
                Console.WriteLine(e.Message);
            }
            catch(Exception ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                Console.WriteLine(ex.StackTrace);

            }
            finally
            {
                if(st1!=null)
                {
                    st1.Close();
                }
                //releasing all the resources in finally block
                Console.WriteLine("final block executed");
            }

            try
            {
                Console.WriteLine("Enter a and b fr division");
                int a, b;
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                int ans = a / b;
                Console.WriteLine(ans);
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Denominator cannot be zero so hence , Arithmetic Exception, Try again !!!");
            }
           
        }
    }
}
