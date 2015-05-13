using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WineGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}\\{1}/{0}", new string('.', i), new string ('*', n - 2*i - 2));
        }

        int someNum;
        if (n >= 12)
        {
            someNum = (n / 2) - 2;
        }
        else
        {
            someNum = (n / 2) - 1;
        }

        for (int i = 0; i < someNum; i++)
        {
            Console.WriteLine("{0}||{0}", new string('.', n/2 - 1));
        }
        if (n >= 12)
        {
            Console.WriteLine(new string('-', n));
            Console.WriteLine(new string('-', n));
        }
        else
        {
            Console.WriteLine(new string('-', n));
        }
    }
}