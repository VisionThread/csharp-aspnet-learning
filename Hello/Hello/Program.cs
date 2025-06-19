using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World, Smruti here ");
        //    Console.Write("C sharp learning......");
        //    Console.WriteLine("programming.");
        //    Console.ReadLine();
        //}
        static void Main1()
        {
            Console.WriteLine("Hello i affirm that whatever is happening with me its happening for the best");

        }
        static void Main()
        {
            Console.WriteLine("Hello world");
            Main1();
            Console.WriteLine("Please enter name..");
            string name= Console.ReadLine();
           //this (concatening name with hello)
           Console.WriteLine("Hello" +" " + name);
            //instead of this one can also write like this
            //or(placeholder syntax)
            Console.WriteLine("Hello {0}",name);

            //now i want to create multiple placeholders
            Console.WriteLine("Please enter last name..");
            string lname=Console.ReadLine();
            Console.WriteLine("Hello {0} {1}",name,lname);

        }

    }
}
