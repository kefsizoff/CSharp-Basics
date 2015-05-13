using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. 
    class Program
    {
        static void Main()
        {
            Console.Write("Number one: ");
            double numberOne = double.Parse(Console.ReadLine());
            Console.Write("Number two: ");
            double numberTwo = double.Parse(Console.ReadLine());
            Console.Write("Number three: ");
            double numberThree = double.Parse(Console.ReadLine());
            Console.Write("Number four: ");
            double numberFour = double.Parse(Console.ReadLine());
            Console.Write("Number five: ");
            double numberFive = double.Parse(Console.ReadLine());

            double sum = numberOne + numberTwo + numberThree + numberFour + numberFive;

            Console.WriteLine("{0} {1} {2} {3} {4} \n The sum of these numbers is : {5}", numberOne, numberTwo, numberThree, numberFour, numberFive, sum);
        }
    }

