using System;


class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Please add a number: ");

        double n = double.Parse(Console.ReadLine());

        if (n == 1)
        {
            Console.WriteLine(0);
        }
        else
        {
            int firstNum = 0;
            int secondNum = 1;
            Console.Write(firstNum + ", ");
            Console.Write(secondNum + ", ");
           

            for (int i = 2; i < n; i++)
            {
                int thirdNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = thirdNum;
                Console.Write(thirdNum + ", ");
            }
            
        }

    }
}