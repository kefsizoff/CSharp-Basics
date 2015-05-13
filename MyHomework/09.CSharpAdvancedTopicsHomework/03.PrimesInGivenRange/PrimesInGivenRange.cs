using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimesInGivenRange
{
    static void Main()
    {
        Console.Write("Please add a start number: ");
        int startNum = int.Parse(Console.ReadLine());
        Console.Write("Please add a end number: ");
        int endNum = int.Parse(Console.ReadLine());
        List<int> listToPrint = (FindPrimesInRange(startNum, endNum));

        foreach (var item in listToPrint)
        {
            Console.Write(item + ", ");
        }
    }

    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> result = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            bool isPrime = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                result.Add(i);
            }
        }
        result.Remove(0);
        result.Remove(1);
        return result;
    }
}