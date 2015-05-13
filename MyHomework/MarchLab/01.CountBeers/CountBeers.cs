using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountBeers
{
    static void Main()
    {
        string input = Console.ReadLine();
        int count = 0;
        int y = 0;
        int x = 0;
        while (input != "End")
        {
            string[] inputs = input.Split(' ');
            if (inputs[1] == "beers")
            {
                count += int.Parse(inputs[0]);

            }
            else
            {
                count += int.Parse(inputs[0]) * 20;
            }
            input = Console.ReadLine();
        }
        y = count % 20;
        x = count / 20;
        Console.WriteLine("{0} stacks + {1} beers", x, y);
    }
}