using System;


class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Квадратното уравнение има следния вид: ax2 + bx + c = 0");
        Console.Write("Моля въведете коефициент a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Моля въведете коефициент b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Моля въведете коефициент c=");
        double c = double.Parse(Console.ReadLine());

        double D = Math.Pow(b, 2) - 4 * a * c;
       
        // ako D = 0 x1=x2= x0 = -b / 2 * a
        double x0 = -b / (2 * a);

        // ako D > 0   x1 = (-b - Math.Sqrt(D)) / 2 * a
        //             x2 = (-b + Math.Sqrt(D)) / 2 * a       
        double x1 = (-b - Math.Sqrt(D)) / (2 * a);
        double x2 = (-b + Math.Sqrt(D)) / (2 * a);
        
        // ako D < 0  Uravnenieto nqma realni koreni
        if (D >= 0)
        {
            if (D == 0)
            {
                Console.WriteLine("D=0, X1 = X2 = {0}", x0);
            }
            else
            {
                Console.WriteLine("X1 = {0}, X2 = {1}", x1, x2);
            }
        }
        else
        {
            Console.WriteLine("Квадратното уравнение няма реални корени - no real roots");
        }
    }
}