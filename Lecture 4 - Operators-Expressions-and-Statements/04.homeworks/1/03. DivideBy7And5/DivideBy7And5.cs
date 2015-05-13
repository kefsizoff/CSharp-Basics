using System;
//Write a Boolean expression that checks for given integer if it can be divided 
//(without remainder) by 7 and 5 in the same time. 
class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Enter some integer:");
        int input = int.Parse(Console.ReadLine());
        bool canDivideBy5And7 = false;
        if (input % 5 == 0 && input % 7 == 0)
        {
            canDivideBy5And7 = true;
        }
        Console.WriteLine("Numer that you entered can be divided by 5 and 7:{0}", canDivideBy5And7);
    }
}

