using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Employee
{
    public string Fn
    {
        get; set;
    }

    public string Ln
    {
        get; set;
    }

    public string Email
    {
        get; set;
    }
    public Employee()
    {
        Console.WriteLine("Parent class constructor");
    }

    public void display()
    {
        Console.WriteLine("{0},{1},{2}",Fn, Ln, Email);
    }
}
//now inheritance
public class PartTimeEmp : Employee
{
    public PartTimeEmp()
    {
        Console.WriteLine("child  constructor called ...");
    }
   public float monthlySal;
}

public class FullTimeEmp : Employee
{
    public float yearlySal;
}

namespace prog7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee();
            //emp.Fn = "Amit";
            //emp.Ln = "Malhotra";
            //emp.Email = "fooaaaaaake@123";

            PartTimeEmp p=new PartTimeEmp();
            p.Fn = "priya";
            p.Ln = "shula";
            p.Email = "kilewer@23.com";
            p.monthlySal = 12344.3F;

           p.display();
        }
    }
}
