using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("n:");
        double n = double.Parse(Console.ReadLine());
        double sum = 0;
        Console.WriteLine();
        for (int i = 1; i <= n; i++)
        {
            Console.Write("number:");
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("Sum={0}", sum);
    }
}
