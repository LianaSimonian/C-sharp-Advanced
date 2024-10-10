
using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { Isbn = "1111", Title = "C# advanced" };

            // var numbers = new List();
            // numbers.Add(1);

            // var books = new BookList();
            // books.Add(book);

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(book);

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234",book);

            var number = new Nullable<int>();
            Console.WriteLine("Has Value ? " + number.HasValue);
            Console.WriteLine("Value " +number.GetValueOrDefault());

        }
    }
}
