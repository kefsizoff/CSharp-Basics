using System;

class calculateNFatorailDividedByKfactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int factn = 1;
        int factk = 1;
        do
        {
            factn *= n;
            if (n <= k)
            {
                factk *= n;
                
            }
            n--;
           
        } while (n >0 );
        Console.WriteLine(factn/factk);


    }
}

