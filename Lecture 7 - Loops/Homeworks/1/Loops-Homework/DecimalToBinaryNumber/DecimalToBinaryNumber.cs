//Using loops write a program that converts an integer number to its binary representation. 
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality

using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        long decNumber = long.Parse(Console.ReadLine());
        string binNumber = "";

        while (decNumber != 0)
        {
            int remain = (int)decNumber % 2;
            decNumber /= 2;
            binNumber = remain + binNumber;
        }
        Console.WriteLine("Your number in binary numeral system is: " + binNumber);
    }
}