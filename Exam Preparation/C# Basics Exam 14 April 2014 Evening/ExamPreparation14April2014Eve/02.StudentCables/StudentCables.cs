using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StudentCables
{
    static void Main()
    {
        int numberOfCables = int.Parse(Console.ReadLine());
        int inCentimeters = 0;

        int cablesToJoin = numberOfCables;

        for (int i = 0; i < numberOfCables; i++)
        {
            int length = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine();

            if (measure == "meters")
            {
                inCentimeters += length * 100;
            }
            else
            {
                if (length >= 20 )
                {
                    inCentimeters += length;
                }
                else
                {
                    cablesToJoin--;
                }
            }
        }
        int weLose = (cablesToJoin - 1) * 3;
        inCentimeters -= weLose;
        
        Console.WriteLine("{0}\n{1}", inCentimeters / 504, inCentimeters % 504);

    }
}