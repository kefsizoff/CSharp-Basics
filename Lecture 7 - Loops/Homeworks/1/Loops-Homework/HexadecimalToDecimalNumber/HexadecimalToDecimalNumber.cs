﻿//Using loops write a program that converts a hexadecimal integer number to its decimal form. 
//The input is entered as string. The output should be a variable of type long. 
//Do not use the built-in .NET functionality

using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal value: ");
        string hexNumber = Console.ReadLine();
        long decNumber = 0;
        long power = 1;

        for (int i = hexNumber.Length - 1; i >= 0; i--)
        {
            int num;
            switch (hexNumber[i])
            {
                case 'A': num = 10; break;
                case 'B': num = 11; break;
                case 'C': num = 12; break;
                case 'D': num = 13; break;
                case 'E': num = 14; break;
                case 'F': num = 15; break;
                default: num = (int)hexNumber[i] - 48; break;
            }
            decNumber += num * power;
            power *= 16;
        }
        Console.WriteLine("Your number in decimal numeral system is: " + decNumber);
    }
}