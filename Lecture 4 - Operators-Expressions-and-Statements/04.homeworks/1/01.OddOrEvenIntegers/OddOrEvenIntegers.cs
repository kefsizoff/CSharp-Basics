using System;
//Write an expression that checks if given integer is odd or even. 
class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Enter some integer:");
        int input = int.Parse(Console.ReadLine());
        bool isOdd = false;
        if (input % 2 != 0)
        {
            isOdd = true;
        }
        Console.WriteLine("Your number is odd:{0}", isOdd);
    }
}

