using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DreamItem
{
    static void Main()
    {
        string input = Console.ReadLine();
        
        


        string[] stringArray = input.Split('\\');

        //string inputMonth = stringArray[0];
        decimal moneyHour = decimal.Parse(stringArray[1]);
        int hoursDayly = int.Parse(stringArray[2]);
        decimal itemPrice = decimal.Parse(stringArray[3]);

        int workDays = 0;

        switch (stringArray[0])
        {
            case "Jan": workDays = 21; break;
            case "Feb": workDays = 18; break;
            case "March": workDays = 21; break;
            case "Apr": workDays = 20; break;
            case "May": workDays = 21; break;
            case "June": workDays = 20; break;
            case "July": workDays = 21; break;
            case "Aug": workDays = 21;break;
            case "Sep": workDays = 20; break;
            case "Oct": workDays = 21; break;
            case "Nov": workDays = 20; break;
            case "Dec": workDays = 21;break;
        }

        decimal money = workDays * moneyHour * hoursDayly;

        if (money > 700)
        {
            money = money * 1.1m;
        }

        if (money > itemPrice)
        {
            decimal moneyLeft = money - itemPrice;
            Console.WriteLine("Money left = {0:F2} leva.", moneyLeft);
        }
        else if (money == itemPrice)
        {
            Console.WriteLine("Money left = {0:F2} leva.", (money - itemPrice));
        }
        else if (money < itemPrice)
        {
            decimal moneyNeeded = itemPrice - money;
            Console.WriteLine("Not enough money. {0:F2} leva needed.", moneyNeeded);
        }
    }
}