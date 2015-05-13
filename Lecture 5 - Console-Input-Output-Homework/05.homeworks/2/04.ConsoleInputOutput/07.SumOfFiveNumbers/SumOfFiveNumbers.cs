using System;

class SumOfFiveNumbers

{
    static void Main()
    {
        string x = Console.ReadLine();
        
        double a = Convert.ToDouble(x.Split(' ')[0]);
        double b = Convert.ToDouble(x.Split(' ')[1]);
        double c = Convert.ToDouble(x.Split(' ')[2]);
        double d = Convert.ToDouble(x.Split(' ')[3]);
        double e = Convert.ToDouble(x.Split(' ')[4]);
        double sum = a,b,c,d,e.Sum();
        
        
        
    }
}

