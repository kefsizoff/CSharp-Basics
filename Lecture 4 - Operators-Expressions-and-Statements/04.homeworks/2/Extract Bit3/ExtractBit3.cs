using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Bit3
{
    class ExtractBit3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bit = (int)(n >> 3) & 1;
            Console.WriteLine(bit);
        }
    }
}
