using System;



class DigitAsWord
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string outPut;
        switch (number)
        {
            case 0: outPut = "Zero"; break;
            case 1: outPut = "One"; break;
            case 2: outPut = "Two"; break;
            case 3: outPut = "Three"; break;
            case 4: outPut = "Four"; break;
            case 5: outPut = "Five"; break;
            case 6: outPut = "Six"; break;
            case 7: outPut = "Seven"; break;
            case 8: outPut = "Eight"; break;
            case 9: outPut = "Nine"; break;

            default: outPut = "Invalid number"; break;               
        }
        Console.WriteLine(outPut);
    }
}

