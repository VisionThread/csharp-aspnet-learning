using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


interface ICustomer
{
    void display(string name);
}

interface I2 : ICustomer
{
    void I2();
}
class A : I2
{
    public void display(string name)
    {
        Console.WriteLine("Name is :{0}",name);
    }
    public void I2()
    {
        Console.WriteLine("Interface methods I2....");
    }
}
//since class A is inheritaing one  interface I2 but it has implementation of both I2 and display method which was in ICustomer
//because I2 inherits  ICustomer so class A has to show implementation of all methods .
//Class A implements the interface I2, which inherits ICustomer.
//This means A must implement all methods from both I2 and ICustomer, as I2 includes everything from ICustomer.

internal class Program
    {
        static void Main(string[] args)
        {
           A a = new A();
           a.display("shruti");
           a.I2();
        }
    }

