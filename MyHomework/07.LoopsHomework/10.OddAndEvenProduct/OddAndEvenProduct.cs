using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class OddAndEvenProduct
    {
        static void Main()
        {

            string numbers = Console.ReadLine();
            int[] array1 = Array.ConvertAll(numbers.Split(' '), int.Parse);
            
            int evenProducts = 1;
            int oddProducts = 1;

            foreach (var item in array1)
            {
                if (Array.IndexOf(array1, item) % 2 == 1)
                {
                    evenProducts *= item;
                }
                else
                {
                    oddProducts *= item;
                }
            }

            if (evenProducts == oddProducts)
            {
                Console.WriteLine("yes \nproduct = {0}", evenProducts);
            }
            else
            {
                Console.WriteLine("no \nodd_product = {0}\neven_product = {1}", oddProducts, evenProducts);
            }
        }
    }