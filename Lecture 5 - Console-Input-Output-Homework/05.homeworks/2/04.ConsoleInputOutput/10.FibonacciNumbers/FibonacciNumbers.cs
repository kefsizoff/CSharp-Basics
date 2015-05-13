using System;

class FibonacciNumbers
{
    static void Main()
    {
        int a = 0;
        int b = 1;
        int c = 0;
        
        Console.Write("n:");
       
        int n = int.Parse(Console.ReadLine());
        if (n == 0)
        {
            Console.Write(a);
        }
        else
        {
            Console.Write  ("{0} {1}",a, b);
        }
       
        for (int i =2; i <= n-1; i++)
        {
            c = a + b;
            
            Console.Write(" {0}", c);
            
            a = b;
            b = c;
        }
        Console.ReadLine();
    }
}

