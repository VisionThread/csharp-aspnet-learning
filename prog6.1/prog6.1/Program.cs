using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ques 1: Create a class `Person` with properties `Name` and `Age`, and a method to display the details.
// Instantiate and use the class.


class Person
{
    string name;
    int age;

    public Person(string n,int a)
    {
        Console.WriteLine("Instance constructor");
        this.name = n;
        this.age = a;
    }

    public void display()
    {
        Console.WriteLine("Name of Person={0}.\n Age of {0} : {1}", name, age);
    }
}

    internal class Program
    {
        static void Main(string[] args)
        {
         
        Person p1 = new Person("Raju",21);
         p1.display();

        Person p2 = new Person("Priya", 23);
        p2.display();

    }
    }
