using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddOrEvenIntegers
{
    class oddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool check = n % 2 == 1;
            Console.WriteLine(check);
        }
    }
}
