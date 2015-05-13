using System;
class LongestAreaInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] area = new string[n];

        for (int i = 0; i < n; i++)
        {
            area[i] = Console.ReadLine();
        }

        int length = 0;
        string value = null;

        for (int i = 0; i < area.Length; i++)
        {
            int count = 0;

            for (int j = i; j < area.Length; j++)
            {
                if (area[i] == area[j])
                    count++;
                else
                    break;
            }
            if (length < count)
            {
                length = count;
                value = area[i];
            }
        }
        Console.WriteLine(length);
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(value);
        }
    }
}