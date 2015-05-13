using System;
//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
//•	Puts the last digit in the first position: dabc (in our example 1201).
//•	Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.
class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("please enter four digits:");
        int[] input = new int[4];
        for (int i = 0; i < 4; i++)
        {
            input[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Your number is:");
        foreach (var digit in input)
        {
            Console.Write(digit);
        }
        Console.WriteLine();

        //calculating sum off all digits
        int sumDigits = 0;
        foreach (int digit in input)
        {
            sumDigits += digit;
        }
        Console.WriteLine("The sum off all digits is:{0}", sumDigits);
        //last digit on first position
        int[] shiftedArr = new int[4];
        shiftedArr[0] = input[input.Length - 1];
        for (int i = 1; i <= 3; i++)
        {
            shiftedArr[i] = input[i - 1];
        }
        Console.Write("Last digit on first position:");
        foreach (var digit in shiftedArr)
        {
            Console.Write(digit);
        }
        Console.WriteLine();
        //swaping second and third digit
        int swapMiddleDigits = input[1];
        input[1] = input[input.Length - 2];
        input[input.Length - 2] = swapMiddleDigits;
        Console.Write("After swap second and third digit:");
        foreach (var digit in input)
        {
            Console.Write(digit);
        }
        Console.WriteLine();
    }
}

