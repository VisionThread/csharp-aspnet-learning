using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

class Circle
{
    int radius;          //instance variables
    //float p = 3.14F;      //instance variables
    // Using a static field for 'p' is more efficient as its value does not change. 
    // Instead of creating multiple instances and copies of 'p', we now have a single shared float 'p' 
    // that can be accessed by everyone.
    static float p;

    static Circle()
    {
        Console.WriteLine("Static constructor is called");
        Circle.p = 3.14F;
    }

    public Circle(int r)
    {
        Console.WriteLine(" Instance constructor is called");
        this.radius = r;
    }

    public float Calc()
    {
        return p * radius * radius;
    }

}
//static members are invoked using class name ,where as instance members are invoked using instances (objects) of the class
//an instance members belongs to specific instance(object) of a class,if i create 3 objects there will 3 set of instance members copies of p variable
// if p is static then it will have only one copy so its reduces memory usage.
//static constructors are called before any instance constructors or any static fields for that matter 
//static constructors are called once no matter how may instance constructors are called
class Program
{
    public static void Main()
    {
        Console.WriteLine("enter the desrired radius to calculate are of circle\n");
        int r=int.Parse(Console.ReadLine());    
        Circle c1 = new Circle(r);
        float ans = c1.Calc();
       Console.WriteLine("answer is:{0}", ans);

        Circle c2 = new Circle(19);
        float ans2 = c2.Calc();
        Console.WriteLine("answer of radii 19 is:{0}", ans2);

    }
}
