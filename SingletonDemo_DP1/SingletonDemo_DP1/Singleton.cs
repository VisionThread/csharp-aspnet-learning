using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo_DP1
{
    //The sealed keyword in C# is used to prevent a
    //class from being inherited or a method
    //from being overridden.
    public sealed class Singleton
    {
        private static int counter = 0;
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(()=> new Singleton());
        //public property is used to return onle oen instance of the class
        //leveraging on private property

        //private static readonly object obj = new object();
        public static Singleton GetInstance
        {
            get
            {
                //lock (obj)
                //{
                //    if (instance == null)
                //        instance = new Singleton();
                //}
                return instance.Value;
            }
            
        }

        //Private constructor ensures that object is not instantiated other than with in the class itself
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value :{0} ", counter.ToString());
        }
        public void display(string msg)
        {
            Console.WriteLine("Message: " + msg);
        }
        //so earlier new instances were created everytime
        //but using singleton design pattern , now only one single isntance is created
        //across the application
    }

    //public class DerivedClassA : Singleton
    //{
    //    //this class cannot be derived from Singleton class if sealed keyword is used
    //    //sealed keywords avoids inheritance
    //    //otherwise if signleton class is derivable
    //    //it will violate Single Responsibility Principle
    //    //thats why sealed keyword is used
    //}
}
