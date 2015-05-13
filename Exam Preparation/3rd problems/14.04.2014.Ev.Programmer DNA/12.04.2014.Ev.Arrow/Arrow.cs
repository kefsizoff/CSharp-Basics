using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}",new string('.', n/2), new string('#', n));

        for (int i = 0; i < n-2; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', n / 2), new string('.', n-2));

        }
        Console.WriteLine("{0}{1}{0}", new string('#', n / 2 + 1), new string('.', n-2));

        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', i+1), new string('.', 2 * n - 2*i-5));
        }
        Console.WriteLine("{0}#{0}", new string('.', n-1));
    }
}