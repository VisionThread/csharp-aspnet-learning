using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//explicit interface implementation

interface I1
{
    void display();
}

interface I2
{
    void display();
}
//now we have same signature void display method I1 and I2
//now to explicitly implement the method .

//In this program, both interfaces I1 and I2 have a method display() with the same signature.
//The class Program implements both interfaces explicitly, providing separate definitions for I1.display() and I2.display().
//Explicit implementation is used to avoid conflicts when two interfaces have methods with the same name.
//To call these methods, you need to cast the object p to the specific interface (I1 or I2).
//This ensures the correct implementation of display() is executed based on the interface being referenced.

interface I3
{
    void display();
}
public class Program:I1,I2,I3
{
    //suppose i want one display method to be default so i can 
    void I1.display()
    {
        Console.WriteLine("Interface I1 method ");
    }

     void I2.display()
    {
        Console.WriteLine("Interface I2 method...... ");
    }

    public void display()
    {
        Console.WriteLine("Default method,Start again ");
    }
    public static void Main()
    {
        Program p = new Program();
        ((I1)p).display();
        ((I2)p).display();  //this method is called Type casting is one way to call function 
                            //otherwise  one can call interfaces in this way as well
        Console.WriteLine("---------------------------------------------------------------------------");
        I1 i1 = new Program();
        I2 i2= new Program();
        i1.display();
        i2 .display();
        Console.WriteLine("---------------------------------------------------------------------------");
        p.display();
    }
}