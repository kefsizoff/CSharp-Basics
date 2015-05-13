using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TextBombardment
{
    static void Main()
    {

        string inputText = Console.ReadLine();
        string tableWidthString = Console.ReadLine();
        int tablewidth = int.Parse(tableWidthString);
        string columnNumbersString = Console.ReadLine();
        string [] columnNumbersStringArray = columnNumbersString.Split();
        int[] columnNumbersIntArray = new int[columnNumbersStringArray.Length];

        for (int i = 0; i < columnNumbersStringArray.Length; i++)
        {
            columnNumbersIntArray[i] = int.Parse(columnNumbersStringArray[i]);
        }

        string outputText = inputText;

        for (int i = 0; i < columnNumbersIntArray.Length; i++)
        {

            int currentBombNumber = columnNumbersIntArray[i];
            int currentOutputPosition = currentBombNumber;

            do
            {
                outputText = outputText.Substring(0, currentOutputPosition)
                + ' ' + outputText.Substring(currentOutputPosition + 1);

                currentOutputPosition += tablewidth;


            } while (currentOutputPosition < outputText.Length && outputText[currentOutputPosition] != ' ');

            if (outputText[currentBombNumber] != ' ')
            {
                
            }
        }

        Console.WriteLine(outputText);




    }
}