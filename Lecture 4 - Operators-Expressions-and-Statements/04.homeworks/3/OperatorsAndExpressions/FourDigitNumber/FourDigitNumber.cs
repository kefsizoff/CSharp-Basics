using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("abcd:");

        int number = int.Parse(Console.ReadLine());

        int a = number % 10;

        int b = (number / 10) % 10;

        int c = (number / 100) % 10;

        int d = (number / 1000) % 10;

        Console.WriteLine(a + b + c + d);

        Console.WriteLine("{0}{1}{2}{3}", a, b, c, d);

        Console.WriteLine("{0}{1}{2}{3}", a, d, c, b);

        Console.WriteLine("{0}{1}{2}{3}", d, b, c, a);
    }
}

