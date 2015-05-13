using System;

class PrimeInGivenRange
{
    static bool PrimeCheck(int n)
    {
        int divider = 2;
        int maxdivider = (int)Math.Sqrt(n)+1;
        if (n == 1 || n <= 0)
        {
            return false;
        }


        for (; divider < maxdivider; divider++)
        {

            if (n % divider == 0)
            {
                return false;
            }
        }
        return true;


    }
    static void Main()
    {

        int lowerNumber = int.Parse(Console.ReadLine());
        int uperNumber = int.Parse(Console.ReadLine());
        for (int i = lowerNumber; i <= uperNumber; i++)
        {

            bool prime = PrimeCheck(i);
            if (prime==true)
            {
                Console.Write(i+" ");
            }
            
           
        }
    }
}

