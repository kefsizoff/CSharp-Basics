using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FibonacciNumbers
{
   static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));
        }

   static int Fibonacci(int n)
        {
            int firstNum = 0;
            int secondNum = 1;
            int thirdNum; 

        for (int i = 1; i < n; i++)
            {
                thirdNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = thirdNum;
            }
        thirdNum = firstNum + secondNum;
            return thirdNum;
   }
}