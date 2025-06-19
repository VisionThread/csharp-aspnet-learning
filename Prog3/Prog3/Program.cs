using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prog3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool? a = null;
            //if(a==true)
            //{
            //    Console.WriteLine("user is major!");
            //}
            //else if(a==false) 
            //{
            //    Console.WriteLine("user is not major");
            //}
            //else
            //{
            //    Console.WriteLine("user did not answer");
            //}

            int ? ticketsonsale= null;// this is nullable datatype
            int availticket;
            if( ticketsonsale == null )
            {
                availticket = 0;
            }
            else
            {
                availticket= (int)ticketsonsale; //so now converting nullable datatype to non nullable data type by explicit conversion
            }
            Console.WriteLine(availticket);
            //so instead of this above we can use this

            int? ticket =null;
            int avail = ticket ?? 0;
            Console.WriteLine(avail);

            //string to integer conversion
            string str = "1076";
            int num=int.Parse(str);
            Console.WriteLine(num);

            string str1 = "100TG";
            int num2;
            int.TryParse(str1, out num2);
            Console.WriteLine(num2);
            //getting 3 numbers in array from user
            int[] even = new int[3];
            int i;
            for(i=0;i<3;i++)
            {
                int q = int.Parse(Console.ReadLine());
                even[i] = q;
            }
            for(i=0;i<3;i++)
            {
                Console.Write(even[i]);
            }

            //coffee program
            int totalcost = 0;
            Start:
            Console.WriteLine("1-Small Coffee \n 2-Medium Coffee \n 3-Large Coffee , enter the number");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:Console.WriteLine("Coffee small please");
                    totalcost += 1;
                    break;
                case 2:
                    Console.WriteLine("Coffee medium please");
                    totalcost += 2;
                    break;
                case 3:
                    Console.WriteLine("Coffee large please");
                    totalcost += 3;
                    break;
                default:
                    Console.WriteLine("Wrong please , enter 1 or 2 or 3");
                    break;
            }
            Console.WriteLine("do you want more coffe, Yes or No");
            string dec=Console.ReadLine();
            switch(dec)
            {
                case "Yes": 
                    goto Start;
                    
                case "No": break;
               

            }
            Console.WriteLine("Total bill amt is : {0}", totalcost);
            Console.WriteLine("Thank you !");

        }
    }
}
