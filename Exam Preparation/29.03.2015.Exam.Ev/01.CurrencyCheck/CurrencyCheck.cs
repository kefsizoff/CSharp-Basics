using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class CurrencyCheck
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());

            double minPrice = double.MaxValue;

            double rPrice = (r / 100) * 3.5f;
            double dPrice = d * 1.5f;
            double ePrice = e * 1.95f;
            double bPrice = b / 2;
            double mPrice = m;

            if (rPrice < minPrice)
            {
                minPrice = rPrice;
            }
            if (dPrice < minPrice)
            {
                minPrice = dPrice;
            }
            if (ePrice < minPrice)
            {
                minPrice = ePrice;
            }
            if ( bPrice < minPrice)
            {
                minPrice = bPrice;
            }
            if (mPrice < minPrice)
            {
                minPrice = mPrice;
            }
            Console.WriteLine("{0:F2}",minPrice);
        }
    }