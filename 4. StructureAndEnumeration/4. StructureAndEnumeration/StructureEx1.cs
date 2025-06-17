using System;

///<summary>
/// Structure is collection of heterogenous data under single variable.
/// It is similar to class but more lightweight and mainly used for small data objects
/// 
/// KEY DIFFERENCE BETWEEN STRUCTURE AND CLASS
/// -> Structure is a value type whereas class is a reference type
/// -> Structures are stored in stack whereas classes are stored in heap
/// -> We cannot define parameterless constructor in sturcture but we can in classes
/// 
/// SYNTAX
/// <access_modifier> struct <struct_name> {
///     property and methods
///  } 
/// </summary>




namespace _4.StructureAndEnumeration
{
    public struct Book
    {
        int book_id;
        string title;
        double price;

        // Parameterized constructor
        // public Book(int b, string s, double p)
        // {
        //     book_id = b;
        //    title = t;
        //    price = p;
        // }

        public void SetProperty(int b, string t, double p)
        {
            book_id = b;
            title = t;
            price = p;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("...........Book Details...............");
            Console.WriteLine($"{book_id}\t{title}\t{price}");
        }
    }

    class StructureEx1
    {
        static void Main()
        {
            Book b1 = new Book();
            b1.SetProperty(1001, "Atomic Habits", 199.99);
            b1.DisplayDetails();
        }
    }
}
