using System;

namespace DynamicBinding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static binding
            object obj = new Book();
            obj.GetHashCode();

            //reflection
            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            var result = methodInfo.Invoke(obj,null);
            Console.WriteLine(result);

            //dynamic binding
            dynamic excelObject = "Mosh";
            //excelObject.Optimize();

            dynamic name = "Mosh";
            name = 1;

            int i = 1;
            dynamic d = i;
            long l = d;
        }
    }
}
