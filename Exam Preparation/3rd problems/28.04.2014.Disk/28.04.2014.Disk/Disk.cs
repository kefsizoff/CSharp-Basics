using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Disk
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());

        //tochki
        for (int i = 0; i < (n - 2 * r - 1)/2; i++)
        {
            Console.WriteLine(new string('.', n));
        }

        //Pyrvi red *
        Console.WriteLine("{0}*{0}", new string('.', n / 2 ));

        //pyrvi mejdinni redove
        for (int i = 0; i < r/3; i++)
        {
            Console.WriteLine("{0}{1}*{1}{0}", new string('.', n / 2 - (r / 3 + 1 + i)), new string('*', r / 3 + 1 + i));
        }

        //mejdinni redove
        for (int i = 0; i < r / 2; i++)
        {
            Console.WriteLine("{0}{1}*{1}{0}", new string('.', n / 2 - (r - 1)), new string('*', r - 1));
        }

        //sreda
        Console.WriteLine("{0}{1}*{1}{0}", new string('.', n/2-r), new string('*', r));

        //mejdinni redove
        for (int i = 0; i < r / 2; i++)
        {
            Console.WriteLine("{0}{1}*{1}{0}", new string('.', n / 2 - (r - 1)), new string('*', r - 1));
        }

        //posledni mejdinni redove
        for (int i = 0; i < r / 3; i++)
        {
            Console.WriteLine("{0}{1}*{1}{0}", new string('.', n / 2 - (r - r / 3 - i)), new string('*', r - r / 3 - i));
        }

        //posleden red *
        Console.WriteLine("{0}*{0}", new string('.', n / 2));

        //tochki
        for (int i = 0; i < (n - 2 * r - 1) / 2; i++)
        {
            Console.WriteLine(new string('.', n));
        }
    }
}