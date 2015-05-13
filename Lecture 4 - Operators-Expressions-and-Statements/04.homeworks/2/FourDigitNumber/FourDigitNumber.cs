using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int fourthDigit = number % 10;
            int digitThree = number / 10;
            int thirthDigit = digitThree % 10;
            int digitTwo = number / 100;
            int secondDigit = digitTwo % 10;
            int firstDigit = number / 1000;
            int digitOne = firstDigit % 10;
            Console.WriteLine("Number:"+number);
            Console.WriteLine("Sum:"+(firstDigit+secondDigit+thirthDigit+fourthDigit));
            Console.WriteLine("Reversed: {3}{2}{1}{0}",firstDigit,secondDigit,thirthDigit,fourthDigit);
            Console.WriteLine("Last digit infront: {3}{0}{1}{2}",firstDigit,secondDigit,thirthDigit,fourthDigit);
            Console.WriteLine("Second and third digit exchanged: {0}{2}{1}{3}",firstDigit,secondDigit,thirthDigit,fourthDigit);
        }
    }
}
