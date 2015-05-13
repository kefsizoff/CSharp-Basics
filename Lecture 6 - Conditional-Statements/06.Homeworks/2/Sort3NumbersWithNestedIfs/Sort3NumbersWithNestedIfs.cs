using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sort3NumbersWithNestedIfs
{
    class Sort3NumbersWithNestedIfs
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            Console.WriteLine("Sort 3 Numbers with Nested Ifs");
            Console.WriteLine();

            Console.Write("Entere number a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Entere number b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Entere number c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("a\tb\tc\tresult");
            Console.Write("{0}\t{1}\t{2}\t", a, b, c);

            string result = "{0} {1} {2}";

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine(result, a, b , c);
                }
                else
                {
                    Console.WriteLine(result, a, c, b);
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine(result, b, a, c);
                }
                else
                {
                    Console.WriteLine(result, b, c, a);
                }
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine(result, c, a, b);
                }
                else
                {
                    Console.WriteLine(result, c, b, a);
                }
            }
            Console.WriteLine();
        }
    }
}
