using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', n/2-i), new string('*', 1 + 2 * i));
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{1}{0}{1}", new string('*', n - 2), new string('|', 1));
        }
    }
}