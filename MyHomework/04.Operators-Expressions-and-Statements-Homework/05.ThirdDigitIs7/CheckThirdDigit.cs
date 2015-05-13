using System;

    class CheckThirdDigit
    {
        static void Main()
        {
            int n = 9999799;
            int firstNum = (n / 100) % 10;
            bool is7 = (firstNum == 7);
            Console.WriteLine(is7);
        }
    }

