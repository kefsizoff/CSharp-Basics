using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dashesBefore = (n - 1) / 2;
            int stars = 1;

            do
            {
                Console.Write(new string('-', dashesBefore));
                Console.Write(new string('*', stars));
                Console.Write(new string('-', dashesBefore));
                Console.WriteLine();
                dashesBefore--;
                stars += 2;
                if (dashesBefore == 0)
                {
                    Console.Write(new string('-', dashesBefore));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('-', dashesBefore));
                    Console.WriteLine();
                }
            } while (dashesBefore > 0);

            stars -= 2;
            for (int i = 0; i < n; i++)
            {
                Console.Write('|');
                Console.Write(new string('*', stars));
                Console.Write('|');
                Console.WriteLine();
            }
        }
    }
}