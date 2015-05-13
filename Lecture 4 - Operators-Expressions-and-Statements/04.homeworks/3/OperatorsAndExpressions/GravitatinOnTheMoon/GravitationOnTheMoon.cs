using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your weight: ");
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine("Your weight on planet the earth is:{0} \nYour weight on the moon will be:{1} ", weight, (weight * 0.17));
    }
}

