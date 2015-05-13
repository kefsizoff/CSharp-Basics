using System;
//Write an expression that checks for given integer if its third digit from right-to-left is 7. 
class IsThirdDigit7
{
    static void Main()
    {
        int input = 701;
        bool thirdDigit = (input / 100) % 10 == 7;
        Console.WriteLine(thirdDigit);
    }
}

