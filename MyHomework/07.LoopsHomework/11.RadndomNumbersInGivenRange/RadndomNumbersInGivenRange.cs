using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RadndomNumbersInGivenRange
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        Random num = new Random();
        
        for (int i = 1; i <= n; i++)
        {
            
            int randomNum = num.Next(min, max + 1);
            Console.Write(randomNum);
            
        }
    }
}