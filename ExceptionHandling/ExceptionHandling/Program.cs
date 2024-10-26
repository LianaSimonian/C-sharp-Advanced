using System;
using System.IO;


namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var calculator = new Calculator();
                int result = calculator.Divide(5, 0);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("you cannot divide by 0",ex.Message);
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine("an error occurred ",ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("sorry, an unexpected error occurred ");
            }

            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader("D: file.zip");
                var content = streamReader.ReadToEnd();
            }
            catch (Exception)
            {
                Console.WriteLine("sorry, an unexpected error occurred ");
            }
            finally
            {
                if(streamReader!=null)
                streamReader.Dispose();
            }
        }
    }
}
