using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


//Create a C# console application that simulates a simple library system. The program should include the following functionality:
//Encapsulation: Create a Book class with the following private fields:
//Title(string)
//Author(string)
//IsAvailable(bool)

//Constructors: Create a constructor for the Book class to initialize its properties.

//Inheritance and Polymorphism: Create a LibraryItem base class with a DisplayDetails method.
//Inherit the Book class from LibraryItem and override the DisplayDetails method to display the book's title, author, and availability.

//Interfaces: Define an interface IBorrowable with methods:
//Borrow()
//Return()

//Collections and Iteration: Use a collection (e.g., List<Book>) to store a list of books in the library. Add functionality to:
//Add a new book.
//Display all books.
//Borrow a book by its title.
//Return a book by its title.

//Error Handling: Add error handling to ensure:
//The user cannot borrow a book that is already borrowed.
//The user cannot return a book that was not borrowed.

//User Interaction: Use a menu-driven approach to interact with the user. Allow the user to:
//Add a book.
//View all books.
//Borrow a book.
//Return a book.
//Exit the application.


namespace practice1
{

    public class LibraryItem
    {
        
        public virtual void DisplayDetails()
        {
            Console.WriteLine("Library class ....");
        }
    }


    interface IBorrowable
    {
        void borrow();
        void Return();
    }


    public class Book : LibraryItem, IBorrowable
    {
        private string Title;
        private string Author;
        private bool IsAvailable = true;

        public Book(string t, string a, bool avail)
        {
            this.Title = t;
            this.Author = a;
            this.IsAvailable = avail;
        }

        public string getTitle()
        {
            return Title;
        }
        public string getAuthor()
        {
            return Author;
        }
        public bool isAvail()
        {
            return IsAvailable;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Details of books are : ");
            Console.WriteLine("Title : {0} ,Author : {1}, availability of {0} is : {2}", getTitle(), getAuthor(), isAvail());
        }

        public void borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine("Book is borrowed successfully !!!");
            }
            else
            {
                try
                {
                    throw new BookBorrow();
                }
                catch(BookBorrow ex)
                {
                    Console.WriteLine(ex.Message);
                }
                

            }
        }

        public void Return()
        {
            if (IsAvailable == false)
            {
                IsAvailable = true;
                Console.WriteLine($"You have successfully returned '{Title}'.");
            }
            else
            {
                try
                {
                    throw new BookReturn();
                }
                catch (BookReturn ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }

    public class BookBorrow : Exception
    {
        public BookBorrow() : base("Book is not available to borrow , so try next time") { }
    }
    public class BookReturn : Exception
    {
        public BookReturn() : base("Book is not borrowed") { }

        public BookReturn(string message) : base(message) { }
    }

    internal class Program
    {
        static List<Book> list = new List<Book>(); 
        //declaring collection, list as static so that its objects can be used directly
        static void Main(string[] args)
        {
            //Book b = new Book("The Alchemist", "Paulo Coelho", true);
            ////Console.WriteLine("Title : {0} , Author Name  : {1} , Available : {2} ",b.getTitle(),b.getAuthor(),b.isAvail());
            //b.DisplayDetails();
            bool ch = true;
            while (ch)
            {
                Console.WriteLine("\n1.Add a book.\r\n2.View all books.\r\n3.Borrow a book.\r\n4.Return a book.\r\n5.Exit the application.\n");

                Console.WriteLine("enter your choice : ");
                int c = int.Parse(Console.ReadLine());

                switch (c)
                {
                    case 0:
                        Console.WriteLine("starting the library");
                        break;
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        Console.WriteLine("Display all the books!");
                        Display();
                        break;
                    case 3:
                        BorrowBook();
                        break;
                    case 4:
                        ReturnBook();
                        break;
                    case 5:
                        ch = false;
                        Console.WriteLine("Exiting the Library System. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }



            }

        }
        public static void AddBook()
        {
            string t, a;
           
            Console.WriteLine("Add book give its title and author name");
            Console.Write("Enter book title: ");
            t = Console.ReadLine();
            Console.Write("Enter book author: ");
            a = Console.ReadLine();
            Book b2 = new Book(t, a, true);
            list.Add(b2);
        }

        public static void Display()
        {
            foreach(Book b in list)
            {
               b.DisplayDetails();
            }
        }

        public static void BorrowBook()
        {
            Console.Write("Enter the title of the book to borrow: ");
            string title = Console.ReadLine();

            foreach (var book in list)
            {
                if (book.getTitle().Equals(title))
                {
                    book.borrow();
                    return;
                }
            }

            Console.WriteLine("Book not found in the library.");

        }

        public static void ReturnBook()
        {
            Console.Write("Enter the title of the book to return: ");
            string title = Console.ReadLine();

            foreach (var book in list)
            {
                if (book.getTitle().Equals(title))
                {
                    book.Return();
                    return;
                }
            }

            Console.WriteLine("Book found in the library.");

        }
    }
}
