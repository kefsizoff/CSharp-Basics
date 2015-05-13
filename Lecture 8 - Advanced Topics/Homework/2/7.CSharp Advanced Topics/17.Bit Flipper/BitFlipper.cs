using System;
using System.Collections.Generic;
using System.Linq;

class BitFlipper
{
    static void Main(string[] args)
    {
        ulong num = ulong.Parse(Console.ReadLine());
        string stringBits = Convert.ToString((long)num, 2).PadLeft(64, '0');
        ulong newNum = 0;
        List<char> bits = new List<char>();
        foreach (char symbol in stringBits)
        {
            bits.Add(symbol);
        }

        int bitsLength = 0;

        while (bitsLength <= bits.Count - 2)
        {
            if (bits[bitsLength] == '1' && bits[bitsLength + 1] == '1' && bits[bitsLength + 2] == '1')
            {
                for (int i = 0; i < 3; i++)
                {
                    bits[bitsLength] = '0';
                    bitsLength++;
                }
            }
            else if (bits[bitsLength] == '0' && bits[bitsLength + 1] == '0' && bits[bitsLength + 2] == '0')
            {
                for (int i = 0; i < 3; i++)
                {
                    bits[bitsLength] = '1';
                    bitsLength++;
                }
            }
            else
            {
                bitsLength++;
            }

        }

        for (int i = 0; i < bits.Count; i++)
        {
            if (bits[i] == '1')
            {
                newNum += (ulong)Math.Pow(2, (63 - i));
            }
        }

        Console.WriteLine(newNum);
    }
}
