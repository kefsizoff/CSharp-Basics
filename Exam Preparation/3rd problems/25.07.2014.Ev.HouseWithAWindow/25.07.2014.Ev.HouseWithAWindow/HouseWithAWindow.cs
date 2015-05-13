using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class HouseWithAWindow
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}*{0}", new string('.', n-1));

            for (int counter = 0, i = 0; i < n-1; i++, counter+=2)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', (2*n-1)/2-1-i), new string('.', 1 + counter));
            }

            Console.WriteLine(new string('*', 2 * n - 1));

            for (int i = 0; i < n / 4; i++)
            {
                Console.WriteLine("*{0}*", new string('.', 2 * n - 3));
            }

            // prozorche
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("*{0}{1}{0}*", new string('.', (2 * n - 3 -(n-3))/2), new string('*', n-3));
            }

            for (int i = 0; i < n/4; i++)
            {
                Console.WriteLine("*{0}*", new string('.', 2 * n - 3));
            }
            

            Console.WriteLine(new string('*', 2 * n - 1));

        }
    }