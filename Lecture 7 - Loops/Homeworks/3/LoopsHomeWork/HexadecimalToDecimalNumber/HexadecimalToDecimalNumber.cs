using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter you hexadecimal value: ");
        string hexa = Console.ReadLine();

        long dec = long.Parse(hexa, NumberStyles.HexNumber);

        Console.WriteLine(dec);
    }
}

