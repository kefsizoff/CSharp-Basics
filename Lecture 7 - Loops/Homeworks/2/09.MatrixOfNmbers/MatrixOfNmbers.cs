using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
       
        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j < n+1; j++)
            {
                Console.Write("{0} ",j+i);
       
            }
            Console.WriteLine();
  
            
        }
       
        
       
    }
}

