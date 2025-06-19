using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo_DP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintStudentDetails(),
                () => PrintEmpDetails()
            );
            //PrintStudentDetails();

            //PrintEmpDetails();

            Console.ReadLine();

        }

        private static void PrintEmpDetails()
        {
            Singleton fromEmp = Singleton.GetInstance;
            fromEmp.display("From Employee!");
        }

        private static void PrintStudentDetails()
        {
            //Singleton s1 = Singleton.GetInstance;
            //s1.display("Hello from s1,this is frist message ");
            //s1.display("this is second message");
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.display("From student!");
        }
    }
}
