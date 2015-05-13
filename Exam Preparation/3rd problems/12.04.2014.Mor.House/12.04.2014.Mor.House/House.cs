using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());        

        Console.WriteLine("{0}{1}{0}", new string('.', n/2), new string('*', 1));
        for (int i = 0; i < n / 2 - 1; i++)
        {            
            Console.WriteLine("{0}*{1}*{0}", new string('.', n / 2 - 1 -i), new string('.', 1+2*i));
        }
        Console.WriteLine(new string('*', n));
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', n / 4), new string('.', n - 2 * (n / 4) - 2));
        }
        Console.WriteLine("{0}{1}{0}", new string('.',n/4), new string('*', n-2*(n/4)));
    }
}