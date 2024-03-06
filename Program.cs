using System;
namespace bookStoreRecord
{
    class Program
    {
    public record Bookstore(int ID, string Title, string Author, double Price);

        public static void Main()
        {
            Bookstore book1 = new Bookstore(1, "The Great Gatsby", "F. Scott Fitzgerald", 12.99);
            Console.WriteLine(book1);
            Bookstore book2 = new Bookstore(2, "To Kill a Mockingbird", "Harper Lee", 14.95);
            Console.WriteLine(book2);
            Bookstore book3 = new Bookstore(3, "1984", "George Orwell", 9.99);
            Console.WriteLine(book3);
        }
    }
}