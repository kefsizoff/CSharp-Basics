using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line. Note that you may need to use a for-loop.
    class Program
    {
        static void Main()
        {
          Console.Write("Enter max value :");                      
          int max = int.Parse(Console.ReadLine());
          for (int i=1;i<=max;i++) 
          {
           Console.WriteLine(i);    
          }      
  
        }
    }

