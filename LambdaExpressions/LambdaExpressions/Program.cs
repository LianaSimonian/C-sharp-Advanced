using System;

namespace LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = number => number * number;

            Console.WriteLine(square(5));

            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;
            var result = multiplier(10);
            Console.WriteLine(result);

            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(b => b.Price<10);
        }
    }
}
