using System;


    class SumOfNNumbers
    {
        static void Main()
        {
            Console.Write("Please add a number: ");

            double n = double.Parse(Console.ReadLine());
            double number;
            double sum = 0;
            int a = 1;
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("Please add number {0}: ", a++);
                number = double.Parse(Console.ReadLine());
                sum += number;
                
            }
            Console.WriteLine("The sum of the {0} numbers is: {1}", n, sum);
        }
    }