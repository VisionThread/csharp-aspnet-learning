using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee()
            {
                Id = 1,
                Name = "Mary",
                Salary = 5000,
                Exp = 10
            });
            employees.Add(new Employee()
            {
                Id = 2,
                Name = "Mike",
                Salary = 1000,
                Exp = 3
            });
            employees.Add(new Employee()
            {
                Id = 3,
                Name = "Tim",
                Salary = 3000,
                Exp = 2
            });
            employees.Add(new Employee()
            {
                Id = 4,
                Name = "Mimi",
                Salary = 8000,
                Exp = 5
            });

            //Employee.Promotion(employees);
            IsPromotable del1=new IsPromotable(funcp);
            IsPromotable del2 = new IsPromotable(funcp2);
            Employee.Promotion2(employees,del1);
            Employee.Promotion2(employees, del2);
        }

        public static bool funcp(Employee emp)
        {
            if(emp.Exp>=5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool funcp2(Employee emp)
        {
            if (emp.Salary >= 2000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
//now we have method promotion which will take through loop and promote employess based on experience criteria 
//so if i want to promote employee based on salary we should be able to do that 
delegate bool IsPromotable(Employee e);
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int Salary { get; set; }
           
    public int Exp { get; set; }

    public static void Promotion(List<Employee> employees)
    {
        foreach(Employee e in employees) 
            if(e.Exp>=5)
            {
                Console.WriteLine(e.Name+"  eligible for promotion ");
            }
    }
    //improved version of above logic where there is no hard coding
    public static void Promotion2(List<Employee> employees,IsPromotable isEligible)
    {
        foreach (Employee e in employees)
            if (isEligible(e))
            {
                Console.WriteLine(e.Name + "  eligible for promotion ");
            }
    }











}