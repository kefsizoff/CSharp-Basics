using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool check = (n % 5 == 0 && n % 7 == 0);
            Console.WriteLine(check);
        }
    }
}
