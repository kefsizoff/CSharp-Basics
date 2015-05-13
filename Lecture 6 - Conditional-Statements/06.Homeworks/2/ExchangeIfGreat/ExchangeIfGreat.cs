using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeIfGreat
{
    class ExchangeIfGreat
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exchange If Greater:");
            Console.Write("Enter number a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("a\tb\tresult");

            Console.Write("{0}\t{1}\t", a, b);

            if (a > b)
            {
                int swap = a;
                a = b;
                b = swap;
            }
            Console.WriteLine("{0} {1}", a, b);
            Console.WriteLine();
        }
    }
}
