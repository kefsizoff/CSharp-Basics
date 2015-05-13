using System;


class ComparingFloats
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        const decimal eps = 0.000001m;

        if (Math.Abs(a - b) > eps)
        {
            Console.WriteLine("The numbers are not equal");
        }
        else if (Math.Abs(a - b) < eps)
        {
            Console.WriteLine("The numbers are equal");
        }
        else
        {
            Console.WriteLine("Border Case: The numbers are not equal");
        }
    }
}
