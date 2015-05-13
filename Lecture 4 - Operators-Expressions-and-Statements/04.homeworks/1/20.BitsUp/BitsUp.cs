using System;
class BitsUp
{
    static void Main()
    {
        //long mask = 1;
        int countOfNubers = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int[] inputNumbers = new int[countOfNubers];
        for (int i = 0; i < inputNumbers.Length; i++)
        {
            inputNumbers[i] = int.Parse(Console.ReadLine());
        }
        string allBits = null;
        for (int i = 0; i < inputNumbers.Length; i++)
        {
            string convertToBinary = Convert.ToString(inputNumbers[i], 2).PadLeft(8, '0');
            allBits += convertToBinary;
        }
        char[] stringToArray = allBits.ToCharArray();
        for (int i = 1; i < stringToArray.Length; i+=step)
        {
            if (stringToArray[i]=='0')
            {
                stringToArray[i] = '1';
            }        
        }
        //long allBitsToInt = Convert.ToInt32(allBits, 2);
        //long newResult = allBitsToInt;
        //for (int i = 1; i < countOfNubers * 8; i += step)
        //{

        //    long bitAtIPositionValue = (allBitsToInt >> countOfNubers * 8 - i - 1) & mask;
        //    if (bitAtIPositionValue == 0)
        //    {
        //        newResult = ~(mask << countOfNubers * 8 - i - 1) & newResult;
        //        newResult = (mask << countOfNubers * 8 - i - 1) | newResult;
        //    }
        //}
        string newResultBinary = new string(stringToArray);
        int numberOfBytes = newResultBinary.Length / 8;
        int[] totalBytes = new int[numberOfBytes];
        for (int i = 0; i < numberOfBytes; i++)
        {
            totalBytes[i] = Convert.ToInt32(newResultBinary.Substring(8 * i, 8), 2);
            Console.WriteLine(totalBytes[i]);
        }
    }
}

