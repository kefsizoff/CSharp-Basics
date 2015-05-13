using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBitGivenPosition
{
    class CheckBitGivenPosition
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int bit = (int)(n >> p) & 1;
            int check = bit & 1;
            if (check == 1) Console.WriteLine(true);
            else Console.WriteLine(false);
        }
    }
}
