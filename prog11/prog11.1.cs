using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class prog11.1
{
	 public static void Main()
     {
        try
        {
            Console.WriteLine("Enter the first number: ");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first number: ");
            b = Convert.ToInt32(Console.ReadLine());

            int ans = a / b;
            Console.WriteLine("Ans is :{0}", ans);
        }
         catch(Exception ex)
        {
           Console.Write(ex.Message);
           string filepath = @"C:\Sample\Log.txt";
           StreamWriter sw = new StreamWriter(filepath);
           sw.Write(ex.GetType().Name);
           sw.Write(ex.Message);
           sw.Close();
           Console.WriteLine("There is a problem ,Please try again later");

    }
     }
}
