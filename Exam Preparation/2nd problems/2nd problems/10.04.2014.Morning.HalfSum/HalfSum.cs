using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HalfSum
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int[] array1 = new int[input];
        int[] array2 = new int[input];

        for (int i = 0; i < input; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < input; i++)
        {
            array2[i] = int.Parse(Console.ReadLine());
        }

        if (array1.Sum() == array2.Sum())
        {
            Console.WriteLine("Yes, sum={0}", array1.Sum());
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(array1.Sum() - array2.Sum()));
        }
    }
}