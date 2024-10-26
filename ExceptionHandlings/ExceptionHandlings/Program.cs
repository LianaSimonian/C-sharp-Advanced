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
                using (var streamReader = new StreamReader("D: file.zip"))
                {
                    var content = streamReader.ReadToEnd();
                } ;
            }
            catch (Exception)
            {
                Console.WriteLine("sorry, an unexpected error occurred ");
            }


            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("Mosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
