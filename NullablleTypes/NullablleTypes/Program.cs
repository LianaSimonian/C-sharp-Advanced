using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Nullable<DateTime> date = null;
            DateTime? date2 = null;

            Console.WriteLine("GetValueOrDefault() : " +date.GetValueOrDefault());
            Console.WriteLine("HasValue :"+date.HasValue);
            //Console.WriteLine("Value :" + date.Value);

            DateTime? dateTime = new DateTime(2024,1,1);
            DateTime dateTime2 = dateTime.GetValueOrDefault();

            Console.WriteLine("dateTime2 " + dateTime2);

            DateTime dateTime3 = dateTime ?? DateTime.Today;
            DateTime dateTime4 = (dateTime !=null)?dateTime.GetValueOrDefault() :DateTime.Today;

        }
    }
}
