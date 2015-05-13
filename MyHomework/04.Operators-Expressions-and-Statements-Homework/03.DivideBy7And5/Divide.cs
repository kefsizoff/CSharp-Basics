using System;


class Divide
{
    static void Main()
    {
        int n = 37;
        bool divBy7And5 = (n > 7) && (n % 7 == 0) && (n % 5 == 0);
        Console.WriteLine(divBy7And5);
       
    }
}

