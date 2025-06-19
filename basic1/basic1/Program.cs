using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace basic1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Write a program to check if a number is even or odd.
            //2.Implement a program to find the largest of three numbers entered by the user.
            //3.Write a program to calculate the factorial of a number using a loop.
            //4.Create a program to display the Fibonacci sequence up to a given number of terms.
            //5.Write a program to check if a string is a palindrome.

            //Console.WriteLine("Enter number to check if its even or odd");
            //int a= int.Parse(Console.ReadLine());   
            //func1(a);
            //Console.WriteLine("\n------------------------------------------------------------------------------------------------------------\n");

            //Console.WriteLine("Enter 3 nos to check which one is largest");
            //int r = 3;
            //int i=0;
            //int[] num = new int[r];
            //while (i<r)
            //{
            //    int e=int.Parse(Console.ReadLine());
            //    num[i] = e;
            //    i++;
            //}
            //int ans2 = func2(num);
            //Console.WriteLine("Answer of ques2 : {0}",ans2);
            //Console.WriteLine("\n------------------------------------------------------------------------------------------------------------\n");
            //Console.WriteLine("Enter number to get its factorial");
            //int a1 = int.Parse(Console.ReadLine());
            
            //Console.WriteLine("Answer of ques3 : {0} ", func3(a1));
            //Console.WriteLine("\n------------------------------------------------------------------------------------------------------------\n");
            
            //Console.WriteLine("Enter number to get fibbonaci sequence");
            //int a2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Answer of ques4 :");
            //func4(a2);
            //Console.WriteLine("\n------------------------------------------------------------------------------------------------------------\n");

            Console.WriteLine("Enter string to check palindrome");
            string str = Console.ReadLine();
           
            if(func5(str))
            {
                Console.WriteLine("String is PALINDROME");
            }
            else
            {
                Console.WriteLine("String is NOT PALINDROME");
            }
            
            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------\n");

        }

        public static void func1(int n)
        {
            if(n%2==0)
            {
                Console.WriteLine("Its even number");
            }
            else
            {
                Console.WriteLine("Its odd number");
            }
        }

        public static int func2(int[] arr)
        {
            int max = arr[0];
            int i;
           for(i=1;i<3;i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int func3(int num)
        {
            if (num == 0 | num == 1)
            {
                return 1;
            }

            return num * func3(num - 1);
        }

        public static void func4(int num)
        {
            int t1, t2;
            t1 = 0;
            t2 = 1;
            int i;
            int s = 0;
            for (i=1;i<num;i++)
            {
                Console.WriteLine(t1+ ",");
                s = t1 + t2;
                t1 = t2;
                t2 = s;

            }
        }

        public static bool func5(string str) 
        {
           int len=str.Length;
            Console.WriteLine(str[0]);
            int s, e;
            s = 0;e = len - 1;
            while(s<e)
            {
                if (str[s] != str[e])
                {
                    return false;
                }
                s++;
                e--;
            }
            return true;
        }
    }
}
