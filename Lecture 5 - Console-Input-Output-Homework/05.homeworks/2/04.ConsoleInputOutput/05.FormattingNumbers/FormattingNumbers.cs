using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("!!! 0 <= a <=500 !!!");
        Console.Write("a:");
        int a = int.Parse(Console.ReadLine());
        if (!(0 <= a && a <= 500))
        {
            Console.WriteLine("EROR - 0 <= a <= 500 ");
            Environment.Exit(0);
        }
     
        string binary = Convert.ToString(a, 2).PadLeft(10, '0');
        Console.Write("b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c:");
        double c = double.Parse(Console.ReadLine());

        
        if (b % 1 == 0 || c % 1 == 0 ) 
        {

            
            Console.WriteLine("|{0,-10:X}|{1,10}|{2,10:0.##}|{3,-10:0.###}|", a, binary, b, c);
        }
       
        else
        {
         
            Console.WriteLine("|{0,-10:X}|{1,10}|{2,10:0.00}|{3,-10:0.000}|", a, binary, b, c);

        }

   
        Console.ReadLine();
  
    }
}
