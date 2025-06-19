using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;



//Create an `enum` called `Days` for the days of the week and write a program to display a specific day using its value
//Define an `enum` for vehicle types (`Car`, `Bike`, `Truck`) and use a `switch` case to print a message based on the selected vehicle type.

//3. * *Enum Parsing * *
//   -Write a program where a user enters a day of the week as a string, and the program converts it to the corresponding `enum` value and displays it.

//4. **Enum with Integers**
//   - Create an `enum` for months(`January = 1`, `February = 2`, ...) and write a program that takes a number(e.g., `4`) and prints the corresponding month.

public enum Days
{
    Monday, Tuesday, Wednesday, Thursday,Friday,Saturday, Sunday
}

public enum Month
{
    January=1,Februray=2,March=3,April=4,May=5,June=6,July=7,August=8,Septemeber=9,October=10,November=11,Decemeber=12
}

public enum vehicle
{
    Car,Bike,Truck
}


namespace prog8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string c;
            c = Console.ReadLine();
            //solution 1 switch statement 
            //switch(c)
            //{
            //    case "Mond": Console.WriteLine(Days.Monday);
            //        break;
            //    case "Tue":
            //        Console.WriteLine(Days.Tuesday);
            //        break;
            //    case "Wed":
            //        Console.WriteLine(Days.Wednesday);
            //        break;
            //    case "Thur":
            //        Console.WriteLine(Days.Thursday);
            //        break;
            //     case "Fri":
            //        Console.WriteLine(Days.Friday);
            //        break;
            //    case "Sat":
            //        Console.WriteLine(Days.Saturday);
            //        break;
            //    default:
            //        Console.WriteLine(Days.Sunday);
            //        break;

            //}

            //solution 2 better solution without using switch statement
            string[] d = (string[])Enum.GetNames(typeof(Days));
            foreach(string str in d)
            {
                if(str==c)
                {
                    Console.WriteLine(str);
                }
            }

            //ques 2
            Console.WriteLine("--------------------------------------------------------------------------------------");
            string c1;
            c1 = Console.ReadLine();
            //solution 1 switch statement 
            switch(c1)
            {
                case "C": Console.WriteLine(vehicle.Car);
                    break;
                case "B":
                    Console.WriteLine(vehicle.Bike);
                    break;
                case "T":
                    Console.WriteLine(vehicle.Truck);
                    break;

            }
            Console.WriteLine("--------------------------------------------------------------------------------------");
            //ques 4
            Console.WriteLine("Enter the month :");
            int input = int.Parse(Console.ReadLine());
            int[] val=(int[])Enum.GetValues(typeof(Month));
            foreach(int v in val)
            {
                if(input==v)
                {
                  Console.WriteLine(Enum.GetName(typeof(Month),input));
                }


            }
           


        }
    }
}
