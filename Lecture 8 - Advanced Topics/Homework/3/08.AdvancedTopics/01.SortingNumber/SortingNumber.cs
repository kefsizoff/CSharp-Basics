using System;
class SortingNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] sortingNum = new int[n];

        for (int i = 0; i < n; i++)
        {
            sortingNum[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(sortingNum);
        foreach (int num in sortingNum)
        {
            Console.WriteLine(num);
        }
    }
}
