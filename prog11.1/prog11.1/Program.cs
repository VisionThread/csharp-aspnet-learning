using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;




public class Program
{

     public static void Main()
    {
        try
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
            catch (Exception ex)
            {
                //Console.Write(ex.Message);
                string filepath = @"C:\Sample\Log2.txt";
                if (File.Exists(filepath))
                {
                    StreamWriter sw = new StreamWriter(filepath);
                    sw.Write(ex.GetType().Name);
                    sw.Write(ex.Message);
                    sw.Close();
                    Console.WriteLine("There is a problem ,Please try again later");
                }
                else
                {
                    throw new Exception("File not found : " + filepath + " ", ex);
                }


            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Current exception : {0}",ex.GetType().Name);
            Console.WriteLine("Inner exception: {0}", ex.InnerException.GetType().Name);
        }

        //Write a program with nested `try-catch` blocks to handle a format exception (invalid input type)
        //and divide-by-zero exception separately.

        //try
        //{
        //    Console.WriteLine("Enter numbers for division");
        //    int a = int.Parse(Console.ReadLine());
        //    int b = int.Parse(Console.ReadLine());
        //    int ans;
        //    try
        //    {
        //        ans = a / b;
        //        Console.WriteLine("Answer is : {0} ", ans);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine(ex.ToString());
        //        Console.WriteLine(ex.GetType().Name);
        //    }
        //}
        //catch(FormatException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //    Console.WriteLine(ex.GetType().Name);
        //}
        
}
}

