using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            Console.WriteLine("Multiplication sign of three real numbers.");
            Console.WriteLine();
            Console.Write("Enter number a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter number b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter number c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("a\tb\tc\tresult");

            Console.Write("{0}\t{1}\t{2}\t", a, b, c);

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("0");
            }
            else if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else if (a < 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b < 0)
            {
                Console.WriteLine("+");
            }
            else if (b < 0 && c < 0)
            {
                Console.WriteLine("+");
            }

            else
            {
                Console.WriteLine("-");
            }

            Console.WriteLine();
        }
    }
}
