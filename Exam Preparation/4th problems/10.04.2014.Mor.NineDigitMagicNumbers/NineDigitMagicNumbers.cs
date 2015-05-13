using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int numCount = 0;

        for (int i = 111; i <= 777; i++)
        {
            int num1 = i;
            int num2 = num1 + diff;
            int num3 = num2 + diff;

            bool isGoodNum1 = true;
            bool isGoodNum2 = true;
            bool isGoodNum3 = true;

            //num1
            string num1String = num1.ToString();
            char[] num1Chars = num1String.ToArray();

            foreach (var digit in num1Chars)
            {
                if (digit < '1' || digit > '7')
                {
                    isGoodNum1 = false;
                    break;
                }
            }
            //num2
            string num2String = num2.ToString();
            char[] num2Chars = num2String.ToArray();

            foreach (var digit in num2Chars)
            {
                if (digit < '1' || digit > '7')
                {
                    isGoodNum2 = false;
                    break;
                }
            }
            //num3
            string num3String = num3.ToString();
            char[] num3Chars = num3String.ToArray();

            foreach (var digit in num3Chars)
            {
                if (digit < '1' || digit > '7')
                {
                    isGoodNum3 = false;
                    break;
                }
            }

            // ako vsichki chisla sa korektni
            if (isGoodNum1 && isGoodNum2 && isGoodNum3)
            {
                //Sumirame cifrite na pyrvoto chislo
                int[] num1Arr= new int[3];
                
                for (int j = 0; j < num1Arr.Length; j++)
                {
                    num1Arr[j] = Convert.ToInt32(num1Chars[j]) - 48;
                }
                int number1Sum = num1Arr.Sum();


                //Sumirame cifrite na vtoroto chislo
                int[] num2Arr = new int[3];

                for (int j = 0; j < num2Arr.Length; j++)
                {
                    num2Arr[j] = Convert.ToInt32(num2Chars[j]) - 48;
                }
                int number2Sum = num2Arr.Sum();


                //Sumirame cifrite na tretoto chislo
                int[] num3Arr = new int[3];

                for (int j = 0; j < num3Arr.Length; j++)
                {
                    num3Arr[j] = Convert.ToInt32(num3Chars[j]) - 48;
                }
                int number3Sum = num3Arr.Sum();

                //Proverqvame dali sumata na chislata e ravna na zadadenata
                if (number1Sum + number2Sum + number3Sum == sum)
                {
                    Console.WriteLine("{0}{1}{2}", num1, num2, num3);
                    numCount++;
                }
            }
        }
        if (numCount == 0)
        {
            Console.WriteLine("No");
        }
    }
}