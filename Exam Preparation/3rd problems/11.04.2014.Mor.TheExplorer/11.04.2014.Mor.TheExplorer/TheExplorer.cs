using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}", new string('-', n/2), '*');
        
        for (int i = 0, count = 0; i < n - 2; i++)
        {
            if (i < n / 2)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('-', n / 2 - 1 - count), new string('-', 1 + 2 * count));
                count++;
            }
            else
            {
                count--;
                Console.WriteLine("{0}*{1}*{0}", new string('-', n / 2 - 1 - count +1), new string('-', 1 + 2 * (count-1)));
            }
        }
        Console.WriteLine("{0}{1}{0}", new string('-', n/2), '*');
    }
}