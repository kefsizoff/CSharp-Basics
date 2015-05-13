using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ProgrammerDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char printChar = char.Parse(Console.ReadLine());

        int blockSize = 7;
        char point = '.';
        int midPoint = blockSize / 2;
        int diff = 0;
        int diffCounter = 0;


        for (int counter = 0; counter < n; counter++)
        {
            for (int i = 0; i < blockSize; i++)
            {
                if (i >= midPoint - diff && i <= midPoint + diff)
                {
                    Console.Write(printChar);

                    if (printChar == 'G')
                    {
                        printChar = 'A';
                    }
                    else
                    {
                        printChar++;
                    }
                }
                else
                {
                    Console.Write(point);
                }
            }
            if (diffCounter >= midPoint)
            {
                diff--;
            }
            else
            {
                diff++;
            }

            diffCounter++;

            if (diffCounter == blockSize)
            {
                diffCounter = 0;
                diff++;
            }
            Console.WriteLine();
        }
    }
}