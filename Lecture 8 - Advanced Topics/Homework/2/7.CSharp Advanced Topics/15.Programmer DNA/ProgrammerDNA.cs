using System;
using System.Collections.Generic;
using System.Linq;

class ProgrammerDNA
{
    static void Main(string[] args)
    {
        ushort n = ushort.Parse(Console.ReadLine());
        char startingLetter = Convert.ToChar(Console.ReadLine());
        byte position = 0;
        char dot = '.';

        char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
        for (byte i = 0; i < letters.Length; i++)
        {
            if (startingLetter == letters[i])
            {
                position = i;
                break;
            }
        }
        char[,] dnaField = new char[n, 7];

        short rowCounter = 0;
        while (rowCounter < n)
        {
            byte startCharRow = 3;
            byte endCharRow = 3;

            //нарастване
            for (int i = 0; i < 4; i++)
            {
                //точки преди буквите на реда
                for (int j = 0; j < startCharRow; j++)
                {
                    dnaField[i, j] = dot;
                    Console.Write(dnaField[i, j]);
                }
                //букви на реда
                for (int j = startCharRow; j <= endCharRow; j++)
                {
                    dnaField[i, j] = letters[position];
                    position++;
                    if (position >= 7)
                    {
                        position = 0;
                    }
                    Console.Write(dnaField[i, j]);
                }
                //точки след буквите на реда
                for (int j = endCharRow + 1; j < 7; j++)
                {
                    dnaField[i, j] = dot;
                    Console.Write(dnaField[i, j]);
                }
                startCharRow--;
                endCharRow++;
                rowCounter++;
                Console.WriteLine();
                if (n <= rowCounter)
                {
                    break;
                }
            }
            if (n <= rowCounter)
            {
                break;
            }

            startCharRow += 2;
            endCharRow -= 2;

            //намаляване
            for (int i = 4; i < 7; i++)
            {
                //точки преди буквите на реда
                for (int j = 0; j < startCharRow; j++)
                {
                    dnaField[i, j] = dot;
                    Console.Write(dnaField[i, j]);
                }

                //букви на реда
                for (int j = startCharRow; j <= endCharRow; j++)
                {
                    dnaField[i, j] = letters[position];
                    position++;
                    if (position >= 7)
                    {
                        position = 0;
                    }
                    Console.Write(dnaField[i, j]);
                }

                //точки след буквите на реда
                for (int j = endCharRow + 1; j < 7; j++)
                {
                    dnaField[i, j] = dot;
                    Console.Write(dnaField[i, j]);
                }
                startCharRow++;
                endCharRow--;
                rowCounter++;
                Console.WriteLine();
                if (n <= rowCounter)
                {
                    break;
                }
            }
            if (n <= rowCounter)
            {
                break;
            }
        }
    }
}

