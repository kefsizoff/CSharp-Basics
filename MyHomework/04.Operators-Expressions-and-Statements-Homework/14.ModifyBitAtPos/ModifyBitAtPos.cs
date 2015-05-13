using System;


class ModifyBitAtPos
{
    static void Main()
    {
        int n = 5343;
        int p = 7;
        int v = 0;

        int mask = ~(1 << p);
        int mask1 = 1 << p;
        int result = n & mask;
        int result1 = n | mask1;

        if (v == 0)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine(result1);
        }
        
       
    }
}
