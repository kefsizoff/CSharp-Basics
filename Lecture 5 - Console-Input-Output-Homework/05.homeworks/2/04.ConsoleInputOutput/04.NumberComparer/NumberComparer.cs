using System;

class NumberComparer
    {
        static void Main()
        {
            Console.Write("a:");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b:");
            double b = double.Parse(Console.ReadLine());
            double c = Math.Max(a, b);

            Console.WriteLine("Greater: {0}", c );
            Console.ReadLine();
                                            


        }
    }

