using System;

class MethodFibonacciNumbers
{
    static int CalculateFibNumbers(int n)
    {
        int sum = 0;
        if (n==0||n==1)
        {
            sum=1;
        }
        int a = 0;
        int b = 1;
        for (int i = 1; i <= n; i++)
        {
            sum = b + a;
           
            a = b;
            b = sum;
           
        }
        return sum;
    }
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        
        int sum = CalculateFibNumbers(n);
        
        Console.WriteLine(sum);

       
    }
}

