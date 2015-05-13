using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BitFlipper
{
    static void Main()
    {
        ulong num = ulong.Parse(Console.ReadLine());
        
        string numAsString = Convert.ToString((long)num, 2).PadLeft(64, '0');
        char[] numAsCharArr = numAsString.ToCharArray();

        for (int i = 2; i < numAsCharArr.Length; i++)
        {
            if (numAsCharArr[i] == numAsCharArr[i-1] && numAsCharArr[i] == numAsCharArr[i-2])
            {
                if (numAsCharArr[i] == '0')
                {
                    numAsCharArr[i] = '1';
                    numAsCharArr[i - 1] = '1';
                    numAsCharArr[i - 2] = '1';
                }
                else
                {
                    numAsCharArr[i] = '0';
                    numAsCharArr[i - 1] = '0';
                    numAsCharArr[i - 2] = '0';
                }
                i += 2;
            }
        }
        Console.WriteLine(Convert.ToUInt64(new string(numAsCharArr), 2)); 
    }
}