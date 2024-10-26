
using System;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //LINQ Query operators
            var cheaperBooks =
                from b in books
                where b.Price < 10
                orderby b.Title
                select b;

            //LINQ Extension Methods
            var cheapBooks = books
                .Where(b => b.Price < 10)
                .OrderBy(b=>b.Title);

            foreach(var book in cheapBooks)
                Console.WriteLine(book.Title + " " + book.Price);

            var singleBook = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");
            Console.WriteLine(singleBook.Title);

            var firstBook = books.First(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(firstBook.Title + " " + firstBook.Price);

            var lastBook = books.LastOrDefault(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(lastBook.Title + " " + lastBook.Price);

            var pagedBooks = books.Skip(2).Take(3);
            foreach(var pagedbook in pagedBooks)
                Console.WriteLine(pagedbook.Title);

            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);
            var totalPrices = books.Sum(b => b.Price);
            Console.WriteLine(maxPrice);
            Console.WriteLine(minPrice);
            Console.WriteLine(totalPrices);



        }
    }
}
