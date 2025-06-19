using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create an interface `IShape` with methods `CalculateArea` and `CalculatePerimeter`.
//Implement this interface in classes `Circle` and `Rectangle`.

interface IShape
{
    float CalculateArea();
    float CalculatePerimeter();
}

public class Circle : IShape
{
    static float p=3.14F;
    public float CalculateArea()
    {
        Console.WriteLine("Enter the radius for area of CIRCLE: ");
        int r = int.Parse(Console.ReadLine());
        float ans = p*r* r;
        return ans;
    }
    public float CalculatePerimeter()
    {
        Console.WriteLine("Enter the radius for perimeter of CIRCLE");
        int r = int.Parse(Console.ReadLine());
        float ans = 2* p* r;
        return ans;
    }
}

public class Rectangle : IShape
{
    
    public float CalculateArea()
    {
        Console.WriteLine("Enter the length and breadth for area of RECTANGLE");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        float ans = a*b ;
        return ans;
    }
    public float CalculatePerimeter()
    {
        Console.WriteLine("Enter the length and breadth for perimeter of RECTANGLE");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        float ans = 2*(a+b);
        return ans;
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Main class");
        Rectangle rect = new Rectangle();
        float ans1=rect.CalculateArea();
        Console.WriteLine(ans1);
        Console.WriteLine("-------------------------------------------------------------");
        Circle c = new Circle();
        float ans2 = c.CalculatePerimeter();
        Console.WriteLine(ans2);
    }
}
