using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements. 
namespace _4NumberComparer
{
    class Program
    {
        static void Main()
        {
            Console.Title = "NumberComparer";
            Console.Write("Enter first number: ");
            float firstNum = float.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            float secondNum = float.Parse(Console.ReadLine());
            Console.WriteLine("The greater number is :" + ( Math.Max(firstNum,secondNum)));
            
            
            
        }
    }
}
