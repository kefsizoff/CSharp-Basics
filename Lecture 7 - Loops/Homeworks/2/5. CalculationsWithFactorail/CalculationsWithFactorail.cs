using System;
//numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn
//3	2	2.75000
//4	3	2.07407
//5	-4	0.75781

class CalculationsWithFactorail
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int fact = 1;
        double result = 1;
        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            fact = 1;
            for (int j = 1; j <= i; j++)
            {
                fact *= j;

                
            }
           

            result = Math.Pow((double)x, (double)i);
            sum = sum+((fact / result));

        }
        Console.WriteLine(sum);
        
 
    }
}

