using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DrawFigure
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = n / 2;
        int increasingNum = 1;
        int count = n;
        for (int i = 0; i < n; i++)
        {
            if (i < n/2)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', i), new string('*', count));
                count -= 2;
            }
            else
            {
                Console.WriteLine("{0}{1}{0}", new string('.', m), new string('*', increasingNum));
                m--;
                increasingNum += 2;
            }
        }
    }
}