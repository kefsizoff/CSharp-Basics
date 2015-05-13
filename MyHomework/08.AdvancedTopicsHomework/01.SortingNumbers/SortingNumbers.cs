using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortingNumbers
{
    static void Main()
    {

        Console.WriteLine("Pleaase add a number:");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbers);

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

    }
}