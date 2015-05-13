using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInsideCircleOutsideRectangle
{
    class PointInsideCircleOutsideRectangle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double a = ((1 - x) * (1 - x) + (1- y) * (1 - y));
            bool check = (1.5*1.5) >= a;
            bool checkY = (y < 1 && y > -1);
            bool checkX = (x > -1 && x < 5);
            bool checkRec = checkX & checkY;
            if (checkRec == false && check == true)
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);

            
        }
    }
}
