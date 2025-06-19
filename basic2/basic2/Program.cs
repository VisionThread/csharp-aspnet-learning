using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace basic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic 2 questions");
            Console.WriteLine("6.Write a program to find all prime numbers between 1 and 100.\r\n8. Write a program to generate a multiplication table for a given number.\r\n9. Create a program to count the number of vowels and consonants in a given string.\r\n10. Write a program to reverse a given number.\r\n\r\n11. Write a program to find the sum and average of elements in an array.\r\n12. Implement a program to find the second largest element in an array.\r\n13. Write a program to remove duplicate elements from an array.\r\n14. Create a program to sort an array in ascending and descending order.\r\n15. Write a program to count the frequency of each element in an array.");

            //            6.Write a program to find all prime numbers between 1 and 100.
            //            8.Write a program to generate a multiplication table for a given number.
            //            9.Create a program to count the number of vowels and consonants in a given string.
            //            10.Write a program to reverse a given number.
            //            11.Write a program to find the sum and average of elements in an array.
            //            12.Implement a program to find the second largest element in an array.
            //            13.Write a program to remove duplicate elements from an array.
            //            14.Create a program to sort an array in ascending and descending order.
            //            15.Write a program to count the frequency of each element in an array.

                  Func1();
            Console.WriteLine("\n--------------------------------------------------------------------------------------\n");
            Console.WriteLine("\nEnter the number to get its table");
            int a= int.Parse(Console.ReadLine());
            Func2(a);

            Console.WriteLine("\n--------------------------------------------------------------------------------------\n");
            Console.WriteLine("\nEnter the string to count vowels and consonants");
            string str = Console.ReadLine();
            Func3(str);

            Console.WriteLine("\n--------------------------------------------------------------------------------------\n");
            Console.WriteLine("\nReverse the given number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Answer :{0}",Func4(b));


        }
        public static int Func4(int a)
        {
            int num = a;
            int sum = 0;
            while(a!=0)
            {
                int rem = a % 10;
                sum = sum * 10 + rem;
                a = a / 10;
            }

            return sum;
        }
        public static void Func3(string str)
        {
            int c = 0;
            int len=str.Length;
            int i;
            for(i=0;i<len;i++)
            {
                if (str[i]=='a' || str[i]=='e' || str[i]=='i' || str[i]=='o' || str[i]=='u')
                {
                    c++;
                }
            }
            Console.WriteLine("Vowels in string are : {0}\n Consonants in string are : {1}",c,len-c);
            
        }
        public static void Func2(int n)
        {
            int i;
            for(i=1;i<=10;i++)
            {
                int y = n * i;
                Console.WriteLine(n + "x" + i + "=" + y);
            }
        }

        public static void Func1()
        {
            int i;
            for(i=1;i<=100;i++)
            {
               if(Fb(i))
                {
                    Console.Write(i+",");
                }
            }
            return;
        }

        public static bool Fb(int num)
        {
            int j;

            for (j = 2; j <= Math.Sqrt(num); j++)
            {
                if (num % j == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
