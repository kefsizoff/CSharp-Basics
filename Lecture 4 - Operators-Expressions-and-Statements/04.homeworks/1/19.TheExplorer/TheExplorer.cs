using System;
class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dash = '-';
        char diamond = '*';
        int center = n / 2;
        for (int rows = 1; rows <= n / 2; rows++)
        {
            Console.Write(new string(dash, n / 2 + 1 - rows));
            Console.Write(diamond);
            if (rows > 1)
            {
                Console.Write(new string(dash, 2 * (rows - 1) - 1));
                Console.Write(diamond);
            }
            Console.Write(new string(dash, n / 2 + 1 - rows));
            Console.WriteLine();
        }
        Console.WriteLine("*" + new string(dash, n - 2) + "*");
        for (int rows = n / 2; rows > 0; rows--)
        {
            Console.Write(new string(dash, n / 2 + 1 - rows));
            Console.Write(diamond);
            if (rows > 1)
            {
                Console.Write(new string(dash, 2 * (rows - 1) - 1));
                Console.Write(diamond);
            }
            Console.Write(new string(dash, n / 2 + 1 - rows));
            Console.WriteLine();
        }
    }
}

