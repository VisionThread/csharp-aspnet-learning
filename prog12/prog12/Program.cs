using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer() 
            { Id = 100 ,
              Name="Mark",
              Salary=45000
            };
            Customer c2 = new Customer()
            {
                Id = 101,
                Name = "Riya",
                Salary = 48000
            };
            Customer c3 = new Customer()
            {
                Id = 102,
                Name = "Charlie",
                Salary = 25000
            };

            Dictionary<int, Customer> d = new Dictionary<int, Customer>();
            d.Add(c1.Id, c1);
            d.Add(c2.Id, c2);
            d.Add(c3.Id, c3);
            //method 1
            //foreach(KeyValuePair<int, Customer> c in d)
            //{
            //   Customer cust = c.Value;
            //    Console.WriteLine("Id:{0},Name:{1} ,Salary :{2}",cust.Id,cust.Name,cust.Salary );
            //    Console.WriteLine("------------------------------------------------------------------");
            //}
            ////method 2
            // foreach(Customer cust in d.Values)
            //{
            //    Console.WriteLine("Id:{0},Name:{1} ,Salary :{2}",cust.Id,cust.Name,cust.Salary );
            //    Console.WriteLine("------------------------------------------------------------------");
            //}

            //we will get values of ustomer based on key
            Customer cust;
            if(d.TryGetValue(101,out cust))
            {
                Console.WriteLine("Id:{0},Name:{1} ,Salary :{2}", cust.Id, cust.Name, cust.Salary);
            }
            else
            { Console.WriteLine("Key not found !!"); }
            //to get count of all customers
            Console.WriteLine("Total customers are: {0}",d.Count());

            //count of customer salary more than 25000
            Console.WriteLine("Total customers are: {0}", d.Count(x => x.Value.Salary > 25000));
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------------LIST--------------------------------------------------------------------------------------------");
            List<Customer> list = new List<Customer>();
            list.Add(c1);
            list.Add(c2);   
            list.Add(c3);
             
            foreach(Customer cust1 in list)
            {
                Console.WriteLine("Name : {0},Salary:{1}", cust1.Name, cust1.Salary);
            }
             //since Savings class is derived from Customer class we can add it into the list
            // Savings sc = new Savings();
            //list.Add(sc);

            //index
           Console.WriteLine( list.IndexOf(c1));
            //want to get customers which have name starting with P
            if (list.Exists(x => x.Name.StartsWith("M")))
            {

                Console.WriteLine("Customer exists");
            }
            else { Console.WriteLine("Not exisiting"); }

            //find function
            Customer cust2 = list.Find(x => x.Salary > 25000);
            Console.WriteLine("Name : {0},Salary:{1}", cust2.Name, cust2.Salary);
            Customer cust3 = list.FindLast(x => x.Salary > 25000);
            Console.WriteLine("Returns last matching item from list based on condition.\nName : {0},Salary:{1}", cust3.Name, cust3.Salary);
            
              List<Customer> list2 = list.FindAll(x => x.Id > 100);
           foreach(Customer c in list2)
            {
                Console.WriteLine("Id:{0},Name:{1} ,Salary :{2}", c.Id, c.Name, c.Salary);
            }
            ///Anonymous Method
            List<Employee> list3 = new List<Employee>()
           {
               new Employee{Id=101,Name="Ravi"},
               new Employee{Id=102,Name="Rimsha"},
               new Employee{Id=103,Name="Pari"},
           };

            //step 2
            //Predicate<Employee> Pemp=new Predicate<Employee>(FindEmp);

            ///step 3
            //Employee emp1= list3.Find(x =>Pemp(x));
            //Console.WriteLine("Id:{0},Name:{1}", emp1.Id, emp1.Name);

            // so instead of 3 steps we can write it in anonymous method

            Employee emp1 = list3.Find(delegate (Employee x)
            {
                return x.Id == 101;
            }
            );
            Console.WriteLine("Id:{0},Name:{1}", emp1.Id, emp1.Name);
            //this above whole is anonymous method


            Console.WriteLine("----------------------------FUNC Delegate--------------------------------------------------------------------------");
            Func<Employee, string> selector = x => "Name:" + x.Name;
            IEnumerable<string> name = list3.Select(selector);
            foreach(string n in name)
            {
                Console.WriteLine(n);
            }

            Func<int,int,string> func1=(fn,sn)=>"Sum is  : "+(fn+sn).ToString();
            string res = func1(10, 70);
            Console.WriteLine(res);
        }
        //step 1
        //public static bool FindEmp(Employee emp)
        //{
        //    return emp.Id == 102;
        //}

    }
}


public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int Salary { get; set; }


}

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}
