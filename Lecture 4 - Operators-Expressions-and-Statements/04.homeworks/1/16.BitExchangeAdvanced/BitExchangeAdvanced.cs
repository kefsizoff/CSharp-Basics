using System;
//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. 
//The first and the second sequence of bits may not overlap.
class BitExchangeAdvanced
{
    static void Main()
    {
        uint number = 2369124121;
        int p = 2;
        int q = 22;
        int k = 10;
        int mask = 1;
        uint resultAtP = 0;
        uint resultAtQ = 0;
        if (Math.Max(p, q) + k > 32 || p < 0 || q < 0)
        {
            Console.WriteLine("Out of range");
        }
        else if (Math.Abs(p - q) < k)
        {
            Console.WriteLine("Overlaping");
        }
        else
        {
            for (int i = 0; i < k; i++)
            {
                //get bit at position p
                resultAtP = (uint)(number >> p & mask);
                //get bit at position q
                resultAtQ = (uint)(number >> q & mask);
                //make bits zero
                number = (uint)(~(resultAtP << p)) & number;
                number = (uint)(~(resultAtQ << q)) & number;
                //assign new values to bits
                number = (resultAtP << q) | number;
                number = (resultAtQ << p) | number;
                p++;
                q++;            
            }
            Console.WriteLine(number);
        }
    }
}

