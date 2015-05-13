using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WorkHours
{
    static void Main()
    {
        uint hours = uint.Parse(Console.ReadLine());
        double days = int.Parse(Console.ReadLine());
        double percent = int.Parse(Console.ReadLine());

        days = days * 0.9;
        percent = percent / 100;

        double workHours = Math.Floor(days * 12 * percent);

        if (workHours >= hours)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("{0}", workHours - hours);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0}", workHours - hours);
        }
    }
}