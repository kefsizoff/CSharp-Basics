using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlayWithIntDoubleAndString
{
    class PlayWithIntDoubleAndString
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            Console.WriteLine("Play with Int, Double And String");
            Console.WriteLine();

            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            ConsoleKeyInfo selection = Console.ReadKey();
            Console.WriteLine();

            switch (selection.KeyChar)
            {
               case '1':
                    Console.Write("Please enter an int: ");
                    Console.WriteLine(int.Parse(Console.ReadLine()) + 1);
                    break;
                case '2':
                    Console.Write("Please enter a double: ");
                    Console.WriteLine(double.Parse(Console.ReadLine()) + 1);
                    break;
                case '3':
                    Console.Write("Please enter a string: ");
                    Console.WriteLine(Console.ReadLine() + "*");
                    break;
                default:
                    Console.WriteLine("End of the program!");
                    break;
            }
            Console.WriteLine();
        }
    }
}
