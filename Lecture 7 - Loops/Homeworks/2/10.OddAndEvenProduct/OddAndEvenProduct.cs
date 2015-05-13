using System;

class OddAndEvenProduct
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] values = input.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);

            int odd_product = 1;
            int even_product=1 ;
            for (int i = 0; i < values.Length; i++)
            {
                if (i%2==0)
                {
                    odd_product*=int.Parse(values[i]);
                }
                    
                else
                {
                    even_product *= int.Parse(values[i]);
                }
                
            }
            Console.WriteLine(odd_product);
            Console.WriteLine(even_product);
            if (odd_product==even_product)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
     

    }

