using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PiggyBank
{
    static void Main()
    {
        int price = int.Parse(Console.ReadLine());
        int partyDays = int.Parse(Console.ReadLine());
        double moneyMonth = 0;

        moneyMonth = (30 - partyDays) * 2.0 - partyDays * 5;
        if (moneyMonth <= 0)
        {
            Console.WriteLine("never");
        }
        else
        {
            double numOfMonths = Math.Ceiling(price / moneyMonth);

            double years = Math.Floor(numOfMonths / 12);
            double months = numOfMonths % 12;

            Console.WriteLine("{0} years, {1} months", years, months);
        }
    }
}