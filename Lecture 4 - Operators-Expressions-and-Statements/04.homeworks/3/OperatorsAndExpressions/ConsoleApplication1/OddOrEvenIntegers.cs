using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter number for check: ");
        int number = int.Parse(Console.ReadLine());
        bool isEven = number % 2 == 0;
        bool isOdd = number % 3 == 0;
        Console.WriteLine("The number is: " + isOdd);
    }
}

