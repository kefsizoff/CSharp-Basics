using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            double totalWorkdays = d * 0.9;
            double totalWorkHours = totalWorkdays * 12;
            double totalEfficientHours = Math.Floor(totalWorkHours * p / 100);

            int difference = Convert.ToInt32(totalEfficientHours) - h;
            if (difference < 0)
            {
                Console.WriteLine("No");
                Console.WriteLine(difference);
            }
            else if (difference >= 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine(difference);
            }
        }
    }
}