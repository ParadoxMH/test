using System;
using System.Net;
using System.Text;

namespace ConsoleAppForTests
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = "4/30/2020 4:29 PM";

            var dt = DateTime.Parse(time);
            var newDt = Round(dt);

            Console.WriteLine(newDt);
        }
        public static int Round(DateTime dt)
        {
            return dt.Minute >= 30 ? dt.Hour + 1 : dt.Hour;
        }
    }
}

