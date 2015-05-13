using System;

class Program
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        int min = int.MaxValue;
        int sum = 0;
        
        for (int i = 0; i < n; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());
            sum += currentNum;
            max = Math.Max(max, currentNum);
            min = Math.Min(min, currentNum);


        }
        double average =( double)sum/n;
        Console.WriteLine("Min {0}", min);
        Console.WriteLine("Max {0}", max);
        Console.WriteLine("Sum {0}", sum);
        Console.WriteLine("Avg {0:0.00}", average);
       
           
    }
}

 