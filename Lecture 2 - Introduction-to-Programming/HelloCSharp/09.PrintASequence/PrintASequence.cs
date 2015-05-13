using System;


class PrintASequence
{
    static void Main()
    {
        int NumberOfSequence;
        for (int i = 2; i <= 11; i++)
        {
            if (i % 2 == 0)
            {
                NumberOfSequence = i;
            }
            else
            {
                NumberOfSequence = i * (-1);
            }
            Console.WriteLine(NumberOfSequence);
        }       
    }
}
    