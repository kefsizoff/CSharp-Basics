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

        string inputMonth = stringArray[0];
        decimal moneyHour = decimal.Parse(stringArray[1]);
        int hoursDayly = int.Parse(stringArray[2]);
        decimal itemPrice = decimal.Parse(stringArray[3]);

        int workDays = 0;

        if (stringArray[0] == "Jan" || stringArray[0] == "March" || stringArray[0] == "May" || stringArray[0] == "July" || stringArray[0] == "Aug" || stringArray[0] == "Oct" || stringArray[0] == "Dec")
        {
            workDays = 21;
        }
        else if (stringArray[0] == "Feb")
        {
            workDays = 18;
        }
        else
        {
            workDays = 20;
        }

        decimal money = workDays * hoursDayly * moneyHour;
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