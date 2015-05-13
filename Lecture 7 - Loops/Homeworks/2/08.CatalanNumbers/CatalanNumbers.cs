//In combinatorics, the Catalan numbers are calculated by the following formula:
  
//Write a program to calculate the nth Catalan number by given n (1 < n < 100). Examples:
//n	Catalan(n)
//0	1
//5	42
//10	16796
//15	9694845


using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int mutiple = 2*n;
        int add = n+1;
        BigInteger factn = 1;
        BigInteger factNAdd = 1;
        BigInteger factNMutilpy = 1;
        do
        {

            factn *= n;
            n--;

        } while (n > 0);
        
        do
        {
            factNMutilpy *= mutiple;
           
            mutiple--;
        } while (mutiple>0);
       
        do
        {
            factNAdd *= add;
            add--;
        } while (add>0);
        Console.WriteLine(factNMutilpy/(factNAdd*factn));
       

    }
}

