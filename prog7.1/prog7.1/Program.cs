using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Employee
{
    public string Fn { get; set; }
    public string Ln { get; set; }
    public string Email { get; set; }

    public virtual void display()
    {
        Console.WriteLine(" Employee Parent class-- First name :{0},Last Name:{1},Email{2}",Fn,Ln,Email);
    }

}

public class PartTime : Employee
{
    //public override void display()
    //{
    //    Console.WriteLine("Part time employeee--First name :{0},Last Name:{1},Email{2}", Fn, Ln, Email);
    //}
}

public class FullTime : Employee
{
    public override void display()
    {
        Console.WriteLine("Full time employeee--First name :{0},Last Name:{1},Email{2}", Fn, Ln, Email);
    }
}

public class TempEmp : Employee
{
    public override void display()
    {
        Console.WriteLine("Temporary employeee-- First name :{0},Last Name:{1},Email{2}", Fn, Ln, Email);
    }
}

internal class Program
    {
        static void Main(string[] args)
        {
        //in polymorphism
        Employee[] emp = new Employee[5];
        emp[0] = new Employee();
        emp[1] = new FullTime();
        emp[2] = new PartTime();
        emp[3] = new TempEmp();
        emp[4] = new TempEmp();
         foreach (Employee e in emp)
        {
            //  e.display(); with these we are able to methods from parent class
            //now we want to indicator that which employee belongs to which category so we will use virtual keyword in parent class 
            // and "override" keyword in child classes 
            e.display();
            //now we will comment method in partime class , so it will print display method from parent class .

            
        }



        }
    }

