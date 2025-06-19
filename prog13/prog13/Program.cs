using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vehicle
{
    public int Id { get; set; }
    public int Price { get; set; }

    public virtual void display()
    {
        Console.WriteLine("Id: {0} ,Price :{1}", Id, Price);
        Console.WriteLine("Vehicle class ...");
    }
}


public class Car : Vehicle
{
    public string color { get; set; }

    public new void display()
    {
        Console.WriteLine("Id: {0} ,Price :{1} ,Color :{2}", Id, Price, color);
    }
} 
public class Jeep : Vehicle
{
    public int Mileage { get; set; }

    public override void display()
    {
        Console.WriteLine("Id: {0} ,Price :{1} ,Mileage :{2}", Id, Price, Mileage);
    }
}





namespace prog13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vehicles base calss, car and jeep is class ,implementing polymorphism

            Vehicle v = new Vehicle()
            {
                Id = 101,
                Price = 450000
            };

            //v.display();

            Car c1 = new Car()
            {
                Id = 102,
                Price = 3800000,
                color = "Blue"
            };

            Car c2 = new Car()
            {
                Id = 103,
                Price = 1200000,
                color = "Grey"
            };

            Car c3 = new Car()
            {
                Id = 104,
                Price = 3200000,
                color = "White"
            };
            //c1.display();

            Jeep j1 = new Jeep()
            {
                Id=106,
                Price=550000,
                Mileage=64
            };
            Jeep j2 = new Jeep()
            {
                Id = 107,
                Price = 500000,
                Mileage = 190
            };
            Jeep j3 = new Jeep()
            {
                Id = 106,
                Price = 450000,
                Mileage = 50
            };

            //j3.display();

            Vehicle vh = new Car();
            vh.display();

            //vehicle display method from car 
            //new keyword is used in which method is hidden so that from 
            

            //Console.WriteLine(j3.Price.ToString());
            //Console.WriteLine(DateTime.Now);
               
        }
    }
}
