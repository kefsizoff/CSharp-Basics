using System;


class CheckForAPlayCard
{
    static void Main()
    {
        string card = Console.ReadLine();

        switch (card)
        {
            case "J":
                Console.WriteLine("yes");
                break;
            case "Q":
                Console.WriteLine("yes");
                break;
            case "K":
                Console.WriteLine("yes");
                break;
            case "A":
                Console.WriteLine("yes");
                break;
        }
        int num;
        bool check = int.TryParse(card, out num);

        if (num >= 2 && num <= 10)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
