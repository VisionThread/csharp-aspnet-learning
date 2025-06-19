using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using a=Project1.TeamA;
using b=Project1.TeamB;
namespace prog5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // one way to call the display function :
            // Project1.TeamA.classA.display();
            //or
            a.classA.display(); // to call display function from team A
            //if we have two namespaces under one and they have same function of display so one can call display function using full name 
            //Project1.TeamB.classA.display();
            //other using namespace alias
            b.classA.display(); //to call display function from team B
        }
    }
}


}

namespace Project1
{
    namespace TeamB
    {
        class classA
        {
            public static void display()
            {
                Console.WriteLine("You are in Team B , now start working on frontend..");
            }
        }
    }
}