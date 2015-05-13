using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CheatSheet
{
    static void Main()
    {
        int numOfRows = int.Parse(Console.ReadLine());
        int numOfCols = int.Parse(Console.ReadLine());
        long rowStart = int.Parse(Console.ReadLine());
        long colStart = int.Parse(Console.ReadLine());

        for (long i = rowStart; i < rowStart+numOfRows; i++)
        {
            for (long j = colStart; j < colStart + numOfCols; j++)
            {
                if (j == (colStart + numOfCols)-1)
                {
                Console.Write("{0}", i * j);
                    
                }
                else
                {
                    Console.Write("{0} ", i * j);

                }
            }
            Console.WriteLine();
        }
    }
}