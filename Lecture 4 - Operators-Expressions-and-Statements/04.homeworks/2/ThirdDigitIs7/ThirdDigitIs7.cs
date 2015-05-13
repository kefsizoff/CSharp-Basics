using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = n / 100;
            bool check = m %10 == 7;
            Console.WriteLine(check);

        }
    }
}
