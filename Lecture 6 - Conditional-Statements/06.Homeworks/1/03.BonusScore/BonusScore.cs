using System;



class BonusScore
{
    static void Main()
    {
        int score = int.Parse(Console.ReadLine());
        int result;
        if (score > 0 && score < 10)
        {
            if (1 <= score && score <= 3)
            {
                result = score * 10;
                Console.WriteLine(result);
            }
            else if (4 <= score && score <= 6)
            {
                result = score * 100;
                Console.WriteLine(result);
            }
            else if (7 <= score && score <= 9)
            {
                result = score * 1000;
                Console.WriteLine(result);
            }
        }
        else
        {
            Console.WriteLine("Invalid score");
        }
    }
}

