using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new PermanentEmp(1,"John");
            Employee emp2 = new TemporaryEmp(2,"Jared");
            Employee emp3 = new ContractEmp(3, "Ruby");

            Console.WriteLine(string.Format("Employee {0}, bonus :{1}",
                emp1.ToString(),
                emp1.CalculateBonus(30000).ToString()));

            Console.ReadLine();

            
            Console.WriteLine(string.Format("Employee {0}, bonus :{1}",
                emp2.ToString(),
                emp2.CalculateBonus(15000).ToString()));

            Console.WriteLine(string.Format("Employee {0}, bonus :{1}",
               emp3.ToString(),
               emp3.CalculateBonus(15000).ToString()));

            Console.ReadLine();

        }
    }
}
