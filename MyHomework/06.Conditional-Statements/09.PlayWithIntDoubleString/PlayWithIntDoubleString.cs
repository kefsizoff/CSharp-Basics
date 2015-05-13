using System;


class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please chose a type:");
        Console.WriteLine("1 --> int \n2 --> double \n3 --> string");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {

            case 1:
                Console.Write("Please add an integer number:");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number + 1);
                break;

            case 2:
                Console.Write("Please add a double number:");
                double number2 = double.Parse(Console.ReadLine());
                Console.WriteLine(number2 + 1);
                break;
            case 3:
                Console.Write("Please add a string:");
                string text = Console.ReadLine();
                Console.WriteLine(text + "*");
                break;
            default:
                Console.WriteLine("wrong input data");
                break;
        }

    }
}