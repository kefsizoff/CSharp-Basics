using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));

        for (int i = 0; i < n-2; i++)
        {
            Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * n - 2), new string(i==(n-2)/2 ? '|': ' ', n));
        }

        Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));
    }
}