using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MagicWand
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            //pyrvi red
            Console.WriteLine("{0}{1}{0}", new string('.',(3*n+1)/2), '*');


            //otgore
            for (int count = 0, i = 0; i < n/2+1; i++, count+=2)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', (3 * n + 1) / 2-1-i), new string('.', 1+count));
            }

            //gorni
            Console.WriteLine("{0}{1}{0}", new string('*', n), new string('.', n+2));

            //goren cikyl
            for (int count = 0, i = 0; i < n/2; i++, count+=2)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', 1+i), new string('.', 3*n-2 - count));
            }

            for (int count = 0, i = 0; i < n / 2; i++, count += 2)
            {
                Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}", new string('.', (n-3)/2 -i), new string('.', n/2), new string('.', i), new string('.', n));
            }


            Console.WriteLine("{0}{1}*{2}*{1}{0}", new string('*', n/2+1), new string('.', n/2) , new string('.', n));




            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', n), new string('.', n));
            }
            Console.WriteLine("{0}*{1}*{0}", new string('.', n), new string('*', n));

        }
    }