using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new string[] { "Bugatti", "Knight XV", "Cardillac", "BMW", "Tesla" };

            LinqQuerySyntax(cars);
            LinqMethodSyntax(cars);

        }

        public static void LinqQuerySyntax(string[] a)
        {
            var startswithA = from x in a
                              where x.ToLower().Contains("b")
                              orderby x descending
                              select x;

            foreach (var letterA in startswithA)
            {
                Console.WriteLine($"{letterA}");
            }
        }

        public static void LinqMethodSyntax(string[] a)
        {
            var startswithA = a.Where(x => x.ToLower().Contains("b"));
            foreach (var letterA in startswithA)
            {
                Console.WriteLine($"{letterA}");
            }
        }
    }
}
