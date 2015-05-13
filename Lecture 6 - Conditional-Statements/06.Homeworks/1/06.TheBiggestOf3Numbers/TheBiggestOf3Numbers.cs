using System;



class TheBiggestOf3Numbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a >= b && a > c)
        {            
             Console.WriteLine("The biggst number is: {0}", a);         
        }
        else if (b >= a && b > c)
        {
             Console.WriteLine("The biggst number is: {0}", b); 
        }
        else if (c >= a && c > b)
        {
             Console.WriteLine("The biggest number is: {0}", c);
        }         
    }
}

