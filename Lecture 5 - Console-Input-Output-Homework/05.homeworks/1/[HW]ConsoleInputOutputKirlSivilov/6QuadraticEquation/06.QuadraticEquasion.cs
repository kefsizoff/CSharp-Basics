using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
    class Program
    {
        static void Main()
        {
            double coefA;
            double coefB;
            double coefC;
            Console.Write("Enter coeficient a :");
            while(!double.TryParse(Console.ReadLine(),out coefA)||coefA==0)   //coeficient A must be different from 0!
            Console.WriteLine("Please enter correct value,different from 0! :");
            Console.Write("Enter coeficient b :");
            while (!double.TryParse(Console.ReadLine(), out coefB))
            Console.WriteLine("Please enter correct value!(number):");
            Console.Write("Enter coeficient c :");
            while (!double.TryParse(Console.ReadLine(), out coefC))
            Console.WriteLine("Please enter correct value!(number):");
            double discriminant = (coefB*coefB) - (4 * coefA * coefC);
            if(discriminant<0)
            {
                Console.WriteLine("No real roots!");
            }
             else
             {
             Console.WriteLine("x1= {0:0.0}",((-coefB-Math.Sqrt(discriminant))/(2*coefA)));
             Console.WriteLine("x2= {0:0.0}",((-coefB+Math.Sqrt(discriminant))/(2*coefA)));
             }
        }
    }

