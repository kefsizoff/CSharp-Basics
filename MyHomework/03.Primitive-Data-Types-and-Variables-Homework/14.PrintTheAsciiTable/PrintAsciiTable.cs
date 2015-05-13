using System;

    class PrintAsciiTable
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            for (int i = 0; i <= 255; i++)
            {
                char symbol = (char)i;
                Console.WriteLine(symbol);
            }
        }
    }
