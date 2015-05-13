using System;



class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.Write( "Please, choose a type: 1 --> int, 2 --> double, or 3 --> string: ");
        string choice = Console.ReadLine();
        int type = int.Parse(choice);        
        switch (type)
        {
            case 1: int numberA = int.Parse(Console.ReadLine());
                Console.WriteLine(numberA + 1); break;
            case 2: double numberB = double.Parse(Console.ReadLine());
                Console.WriteLine(numberB + 1); break;
            case 3: string word = Console.ReadLine();
                Console.WriteLine(word + "*"); break;
            default: Console.WriteLine("Invalid number"); break;
        }
        Console.WriteLine();          
    }
}

