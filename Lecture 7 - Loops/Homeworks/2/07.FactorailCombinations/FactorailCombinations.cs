using System;
using System.Numerics;

class FactorailCombinations
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int diff = n - k;
        BigInteger factn = 1;
        BigInteger factk = 1;
        BigInteger factdiff = 1;
        
        do
        {
            factn *= n;

            if (n <= k)
            {
                factk *= n;
               
            }
            n--;
        } while (n > 0);
        
        do
        {
            factdiff *= diff;
            diff--;

        } while (diff > 0);
        
        Console.WriteLine(factn/(factk*factdiff));

       
       
    }
 
}

