using System;
using System.Collections.Generic;
using System.Linq;


namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blog post ...";
            var shortenedPost = post.Shorten(5);
            Console.WriteLine(shortenedPost);

            IEnumerable<int> numbers = new List<int>() { 1, 2, 4, 5, 48 };
            var max = numbers.Max();
            Console.WriteLine(max);
        }
    }
}
