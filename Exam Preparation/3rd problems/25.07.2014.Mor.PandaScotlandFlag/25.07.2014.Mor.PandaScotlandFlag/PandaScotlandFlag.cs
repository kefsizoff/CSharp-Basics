using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PandaScotlandFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char character = 'A';

        for (int i = 0; i < n/2; i++, character++)
        {
            if (character == 'Z')
            {
                Console.Write("{0}{1}{2}", new string('~', i), character, new string('#', n - 2 - 2 * i));
                character = 'A';
                Console.WriteLine("{0}{1}", character, new string('~', i));
            }
            else
            {
                Console.Write("{0}{1}{2}", new string('~', i), character, new string('#', n - 2 - 2 * i));
                character++;
                if (character == 'Z')
                {
                    Console.WriteLine("{0}{1}", character, new string('~', i));
                    character = 'A';
                    character--;
                }
                else
                {
                    Console.WriteLine("{0}{1}", character, new string('~', i));
                }
            }
        }
        Console.WriteLine("{0}{1}{0}", new string('-', n/2), character);
        character++;
        
        for (int i = 0, count = 0; i < n / 2; i++, character++, count +=2)
        {
            Console.Write("{0}{1}{2}", new string('~', n/2 - 1 - i), character, new string('#', 1 + count));

            if (character == 'Z')
            {
                character = 'A';
                Console.WriteLine("{0}{1}", character, new string('~', n / 2 - 1 - i));
            }
            else
            {
                Console.WriteLine("{0}{1}", ++character, new string('~', n / 2 - 1 - i));
            }
        }
    }
}