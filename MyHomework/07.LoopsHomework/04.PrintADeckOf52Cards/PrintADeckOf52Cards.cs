using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintADeckOf52Cards
{
    static void Main()
    {
        for (int i = 2; i <= 14; i++)
        {
            Console.WriteLine();
            for (int j = 3; j <= 6; j++)
            {
                if (i <= 10)
                {
                    Console.Write("{0}", i);
                    Console.Write("{0} ", (char)j);
                }
                else
                {
                    switch (i)
                    {
                        case 11:
                            Console.Write("J{0} ", (char)j);
                            break;
                        case 12:
                            Console.Write("Q{0} ", (char)j);
                            break;
                        case 13:
                            Console.Write("K{0} ", (char)j);
                            break;
                        case 14:
                            Console.Write("A{0} ", (char)j);
                            break;
                    }
                }
            }
        }
    }
}