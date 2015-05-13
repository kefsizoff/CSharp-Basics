using System;

//Problem 12. Null Values Arithmetic
//Create a program that assigns null values to an integer and to a double variable. 
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

class NullValuesArithmetic
{
    static void Main()
    {
        int? firtsNumber = null;
        double? secondNumber = null;
        Console.WriteLine("This is the integer with Null value >> " + firtsNumber);
        Console.WriteLine("This is the double with Null value >> " + secondNumber);

        firtsNumber += 5;
        Console.WriteLine("This is null + 5:" + firtsNumber);

        firtsNumber = 111;
        secondNumber = 222;
        Console.WriteLine("This is the integer with value 111>> " + firtsNumber);
        Console.WriteLine("This is the Double with value 222>> " + secondNumber);

    }
}
