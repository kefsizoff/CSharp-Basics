using System;
using System.Collections.Generic;
using System.Linq;

class MagicCarNumbers
{
    static void Main(string[] args)
    {
        ushort magicWeight = ushort.Parse(Console.ReadLine());

        //define weight of the letters
        Dictionary<char, int> lettersWeight = new Dictionary<char, int>();
        lettersWeight['A'] = 10;
        lettersWeight['B'] = 20;
        lettersWeight['C'] = 30;
        lettersWeight['E'] = 50;
        lettersWeight['H'] = 80;
        lettersWeight['K'] = 110;
        lettersWeight['M'] = 130;
        lettersWeight['P'] = 160;
        lettersWeight['T'] = 200;
        lettersWeight['X'] = 240;

        int totalMagicWeightNumbers = 0;
        int[] carsNumber = new int[6];

        for (int i = 0; i <= 9; i++)
        {
            carsNumber[0] = i;
            for (int j = 0; j <= 9; j++)
            {
                carsNumber[1] = j;
                for (int k = 0; k <= 9; k++)
                {
                    carsNumber[2] = k;
                    for (int l = 0; l <= 9; l++)
                    {
                        carsNumber[3] = l;
                        foreach (var item in lettersWeight)
                        {
                            carsNumber[4] = item.Value;
                            foreach (var entry in lettersWeight)
                            {
                                carsNumber[5] = entry.Value;
                                int weightSum = 40 + carsNumber.Sum();

                                if (weightSum == magicWeight)
                                {
                                    if (carsNumber[0] == carsNumber[1] && carsNumber[1] == carsNumber[2] && carsNumber[2] == carsNumber[3])
                                    {
                                        totalMagicWeightNumbers++;
                                        //Console.Write("CA{0}{1}{2}{3}{4}{5} ", carsNumber[0], carsNumber[1], carsNumber[2], carsNumber[3], item.Key, entry.Key);
                                    }
                                    else if (carsNumber[0] == carsNumber[1] && carsNumber[1] == carsNumber[2])
                                    {
                                        totalMagicWeightNumbers++;
                                        //Console.Write("CA{0}{1}{2}{3}{4}{5} ", carsNumber[0], carsNumber[1], carsNumber[2], carsNumber[3], item.Key, entry.Key);
                                    }
                                    else if (carsNumber[1] == carsNumber[2] && carsNumber[2] == carsNumber[3])
                                    {
                                        totalMagicWeightNumbers++;
                                        //Console.Write("CA{0}{1}{2}{3}{4}{5} ", carsNumber[0], carsNumber[1], carsNumber[2], carsNumber[3], item.Key, entry.Key);
                                    }
                                    else if (carsNumber[0] == carsNumber[1] && carsNumber[2] == carsNumber[3])
                                    {
                                        totalMagicWeightNumbers++;
                                        //Console.Write("CA{0}{1}{2}{3}{4}{5} ", carsNumber[0], carsNumber[1], carsNumber[2], carsNumber[3], item.Key, entry.Key);
                                    }
                                    else if (carsNumber[0] == carsNumber[2] && carsNumber[1] == carsNumber[3])
                                    {
                                        totalMagicWeightNumbers++;
                                        //Console.Write("CA{0}{1}{2}{3}{4}{5} ", carsNumber[0], carsNumber[1], carsNumber[2], carsNumber[3], item.Key, entry.Key);
                                    }
                                    else if (carsNumber[0] == carsNumber[3] && carsNumber[1] == carsNumber[2])
                                    {
                                        totalMagicWeightNumbers++;
                                        //Console.Write("CA{0}{1}{2}{3}{4}{5} ", carsNumber[0], carsNumber[1], carsNumber[2], carsNumber[3], item.Key, entry.Key);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(totalMagicWeightNumbers);
    }
}

