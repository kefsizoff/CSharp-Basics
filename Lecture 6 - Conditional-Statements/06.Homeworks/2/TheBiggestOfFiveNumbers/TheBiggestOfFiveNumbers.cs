using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Biggest of Five Numbers.");
            Console.WriteLine();

            Console.Write("Enter number a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter number b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter number c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Enter number d: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Enter number e: ");
            double e = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double biggest = a;

            if (biggest < b)
            {
                biggest = b;
            }
            if (biggest < c)
            {
                biggest = c;
            }
            if (biggest < d)
            {
                biggest = d;
            }
            if (biggest < e)
            {
                biggest = e;
            }

            Console.WriteLine("a\tb\tc\td\te\tbiggest");

            Console.Write("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", a, b, c, d, e, biggest);

            Console.WriteLine();
        }
    }
}
