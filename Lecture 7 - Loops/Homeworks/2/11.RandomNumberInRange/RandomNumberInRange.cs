using System;

class RandomNumberInRange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        Random num = new Random();
        for (int i = 0; i < n; i++)
        {
            
            Console.Write(num.Next(min,max+1)+" ");
        }

    }
}

