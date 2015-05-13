using System;

class MagicString
{
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        char[] letters = { 'k', 'n', 'p', 's' };
        int counter = 0;
        for (int i = 0; i < letters.Length; i++)
        {
            for (int i2 = 0; i2 < letters.Length; i2++)
            {
                for (int i3 = 0; i3 < letters.Length; i3++)
                {
                    for (int i4 = 0; i4 < letters.Length; i4++)
                    {
                        for (int i5 = 0; i5 < letters.Length; i5++)
                        {
                            for (int i6 = 0; i6 < letters.Length; i6++)
                            {
                                for (int i7 = 0; i7 < letters.Length; i7++)
                                {
                                    for (int i8 = 0; i8 < letters.Length; i8++)
                                    {
                                        string testString = letters[i].ToString() + letters[i2] + letters[i3]+letters[i4]+letters[i5]+letters[i6]+letters[i7]+letters[i8];
                                        if (CalculateWeight(testString) == diff)
                                        {
                                            Console.WriteLine(testString);
                                            counter++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (counter==0)
        {
            Console.WriteLine("No");
        }
    }

    static int CalculateWeight(string letters)
    {
        int weight1 = 0;
        int weight2 = 0;
        char[] letter = letters.ToCharArray();
        for (int i = 0; i < letter.Length / 2; i++)
        {
            switch (letter[i])
            {
                case 'k': weight1 += 1; break;
                case 'n': weight1 += 4; break;
                case 'p': weight1 += 5; break;
                case 's': weight1 += 3; break;
            }
        }
        for (int i = letter.Length / 2; i < letter.Length; i++)
        {
            switch (letter[i])
            {
                case 'k': weight2 += 1; break;
                case 'n': weight2 += 4; break;
                case 'p': weight2 += 5; break;
                case 's': weight2 += 3; break;
            }
        }
        return Math.Abs(weight1-weight2);
    }
}