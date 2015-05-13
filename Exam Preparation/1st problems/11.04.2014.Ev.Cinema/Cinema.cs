using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Cinema
{
    static void Main()
    {
        string input = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        double price = 0;
        switch (input)
        {
            case "Premiere": price = 12.00; break;
            case "Normal": price = 7.50; break;
            case "Discount": price = 5.00; break;
        }
        double income = rows * cols * price;
        Console.WriteLine("{0:F2} leva", income);
    }
}