using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class InsideTheBuilding
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());
        int x4 = int.Parse(Console.ReadLine());
        int y4 = int.Parse(Console.ReadLine());
        int x5 = int.Parse(Console.ReadLine());
        int y5 = int.Parse(Console.ReadLine());

        Console.WriteLine(InTheBuilding(x1, y1, h));
        Console.WriteLine(InTheBuilding(x2, y2, h));
        Console.WriteLine(InTheBuilding(x3, y3, h));
        Console.WriteLine(InTheBuilding(x4, y4, h));
        Console.WriteLine(InTheBuilding(x5, y5, h));
    }
    private static string InTheBuilding(int x, int y, int h)
    {
        bool isInsideDown = (x >= 0 && x <= 3 * h && y >= 0 && y <= h);
        
        bool isInsideUp = (x >= h && x <= 2 * h && y >= h && y <= 4 * h);
        bool isItIn = isInsideDown || isInsideUp;

        string result = isItIn ? "inside" : "outside";
        return result;
    }
}

        