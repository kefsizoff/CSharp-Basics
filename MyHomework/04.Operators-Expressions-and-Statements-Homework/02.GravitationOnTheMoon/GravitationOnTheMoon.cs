﻿using System;

//Problem 2:
//The gravitational field of the Moon is approximately 17% of that on the Earth. 
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Моля въведи тегло: ");
        double weight = double.Parse(Console.ReadLine());
        double weightOnMoon = weight * 0.17;
        Console.WriteLine("На луната ще тежиш: {0} кг", weightOnMoon);
    }
}