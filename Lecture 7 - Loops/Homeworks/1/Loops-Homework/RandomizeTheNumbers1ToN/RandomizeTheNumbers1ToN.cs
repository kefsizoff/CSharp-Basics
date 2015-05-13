//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order

using System;

class RandomizeTheNumbers1ToN
{
    static void Main()
    {
        Console.Write("Enter an integer value for n: ");
        int num = int.Parse(Console.ReadLine());
        int[] array = new int[num];

        for (int index = 0; index < num; index++)
        {
            array[index] = index + 1;
        }

        Random random = new Random();

        foreach (int index in array)
        {
            int randNum = random.Next(0, num);
            int temp = array[randNum];
            array[randNum] = array[0];
            array[0] = temp;
        }
        Console.WriteLine(String.Join(" ", array));
    }
}