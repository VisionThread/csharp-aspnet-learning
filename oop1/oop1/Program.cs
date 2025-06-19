using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program to demonstrate the concept of inheritance by creating a class hierarchy for `Vehicle`, `Car`, and `Bike`.

public class Vehicle
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Amount { get; set; }
    
    public Vehicle()
    {

        Console.WriteLine("Vehicle class is called");
    }
    public void display()
    {
        Console.WriteLine("Id:{0},Name:{1},Amt:{2}",Id,Name,Amount);
    }
}

public class Car : Vehicle
{
   public string color {  get; set; }
    public Car()
    {
        Console.WriteLine(" Car child class construnctor.");
    }
    public void displayCar()
    {
        Console.WriteLine("Color of car is  : {0}", color);
    }
}

public class Bike : Vehicle
{
  public string Brand {  get; set; }
    public Bike()
    {
        Console.WriteLine("Bike child class construnctor.");
    }
    public void displayBike()
    {
        Console.WriteLine("Bike brand : {0}", Brand);
    }
}

internal class Program
    {
        static void Main(string[] args)
        {
          Bike b=new Bike();
           b.Id = 1;
           b.Name = "Dinesh";
           b.Amount = 900000;
        b.Brand = "TATA";
        b.displayBike();
           b.display();

           Car c= new Car();
           c.Id = 2;
           c.Name = "Priya";
           c.Amount = 20000000;
           c.color = "Blue";
           c.displayCar();
           c.display();
        

        }
    }

