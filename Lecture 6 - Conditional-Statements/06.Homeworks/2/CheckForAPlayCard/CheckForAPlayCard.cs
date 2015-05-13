using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForAPlayCard
{
    class CheckForAPlayCard
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a card sign: ");
            string cardSign = Console.ReadLine();
            
            Console.WriteLine("Character\tIs valid card sign?");
            Console.Write("{0}\t\t", cardSign);
            switch (cardSign)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A":
                    Console.WriteLine("Yes");
                    break;
                default:
                    Console.WriteLine("No");
                    break;
            }
        }
    }
}
