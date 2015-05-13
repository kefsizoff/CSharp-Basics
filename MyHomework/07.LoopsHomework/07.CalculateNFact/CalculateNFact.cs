using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculateNFact
{
    static void Main()
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("k= ");
        int k = int.Parse(Console.ReadLine());

        int nFactorial = 1;
        int kFactorial = 1;
        int nkFactorial = 1;
        int result;

        if (k > 1 && k < 100 && n > 1 && n < 100 && n > k)
        {

            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
                if (i <= k)
                {
                    kFactorial *= i;
                }
            }

            for (int i = 1; i <= n-k; i++)
            {
                nkFactorial *= i;
            }

            
            result = nFactorial / (kFactorial * nkFactorial);

            Console.Write("N! / (K! * (N-K)! = ");
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("n must be greater than k and smaller than 100");
        }
    }
}