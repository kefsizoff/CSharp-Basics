using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a score: ");
            int scores = int.Parse(Console.ReadLine());

            Console.WriteLine("score\tresult");
            Console.Write("{0}\t", scores);

            int? result = null;

            if (scores >= 1 && scores <= 3)
            {
                result = scores * 10;
            }
            if (scores >= 4 && scores <= 6)
            {
                result = scores * 100;
            }
            if (scores >= 7 && scores <= 9)
            {
                result = scores * 1000;
            }
            if (result != null)
            {

                Console.WriteLine("{0}", result);
            }
            else
            {
                Console.WriteLine("Invalid scores");
            }
            Console.WriteLine();
        }
    }
}
