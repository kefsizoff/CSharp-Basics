using System;


class FourDigitNumber
{
    static void Main()
    {
        int a = 2;
        int b = 0;
        int c = 1;
        int d = 1;

        string aString = Convert.ToString(a);
        string bString = Convert.ToString(b);
        string cString = Convert.ToString(c);
        string dString = Convert.ToString(d);

        string n = aString + bString + cString + dString;
        int sumOfDigits = a + b + c + d;
        string reversed = dString + cString + bString + aString;
        string lastInFront = dString + aString + bString + cString;
        string secondAndThirdEx = aString + cString + bString + dString;

        Console.WriteLine(n);
        Console.WriteLine(sumOfDigits);
        Console.WriteLine(reversed);
        Console.WriteLine(lastInFront);
        Console.WriteLine(secondAndThirdEx);

    }
}
