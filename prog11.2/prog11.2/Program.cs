using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int a =int.Parse(Console.ReadLine());
            try
            {
                if (a < 0)
                {
                    throw new CustomException();
                }

            }
            catch(CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
//to create your own custom exception

public class CustomException : Exception
{
    public CustomException():base("This is my custom exception !! Invalid input negative number") { }


    public CustomException(string message):base(message) { }


    public CustomException(string message, Exception innerException):base(message, innerException) { }

}
