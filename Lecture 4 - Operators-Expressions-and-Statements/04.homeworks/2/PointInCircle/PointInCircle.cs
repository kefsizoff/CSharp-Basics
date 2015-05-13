using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInCircle
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double a = ((0 - x) * (0 - x) + (0 - y) * (0 - y));
            bool check = 4 > a;
            Console.WriteLine(check);
        }
    }
}
