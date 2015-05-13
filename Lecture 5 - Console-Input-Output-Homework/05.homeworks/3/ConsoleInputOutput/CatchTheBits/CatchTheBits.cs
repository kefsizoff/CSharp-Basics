using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitTesting
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());

            int index = 0;
            int outputNum = 0;
            int bitCounter = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                for (int j = 7; j >= 0; j--)
                {
                    if ((index % step == 1) || (step == 1 && index > 0))
                    {
                        int bitValue = num >> j & 1;
                        outputNum = (outputNum << 1) | bitValue;
                        bitCounter++;
                    }
                    if (bitCounter == 8)
                    {
                        Console.WriteLine(outputNum);
                        outputNum = 0;
                        bitCounter = 0;
                    }
                    index++;
                }
            }
            if (bitCounter > 0)
            {
                Console.WriteLine(outputNum << (8 - bitCounter));
            }
        }
    }
}