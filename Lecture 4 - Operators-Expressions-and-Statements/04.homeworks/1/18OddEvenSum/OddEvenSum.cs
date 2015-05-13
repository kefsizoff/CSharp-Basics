using System;
class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[2 * n];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int sumOddNumber = 0;
        int sumEvenNumbers = 0;
        for (int i = 0; i < numbers.Length; i += 2)
        {
            sumOddNumber += numbers[i];
        }
        for (int i = 1; i < numbers.Length; i += 2)
        {
            sumEvenNumbers += numbers[i];
        }
        if (sumEvenNumbers == sumOddNumber)
        {
            Console.WriteLine("Yes, sum={0}", sumOddNumber);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sumOddNumber - sumEvenNumbers));
        }
    }
}

