﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RandomizeTheNumbers1ToN
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Random randomNumbers = new Random();

        for (int i = 1; i <= n; i++)
        {
            Console.Write(randomNumbers.Next(1, n + 1) + " ");
        }

        Console.WriteLine();
    }
}

