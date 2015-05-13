using System;


class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Please insert a number between 0 and 500:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please insert a floating-point number:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please insert a floating-point number:");
        double c = double.Parse(Console.ReadLine());
        string binaryA = Convert.ToString(a, 2).PadLeft(10, '0');
       // Console.WriteLine("|{0,-10:X}|{1,10}|{2,10:F2}|{3,-10:0.###}|", a, binaryA, b, c);

        if (b % 1 == 0 || c % 1 == 0)
        {
            Console.WriteLine("|{0,-10:X}|{1,10}|{2,10:0.##}|{3,-10:0.###}|", a, binaryA, b, c);
        }
        else
        {
            Console.WriteLine("|{0,-10:X}|{1,10}|{2,10:F2}|{3,-10:F3}|", a, binaryA, b, c);
        }

    }
}