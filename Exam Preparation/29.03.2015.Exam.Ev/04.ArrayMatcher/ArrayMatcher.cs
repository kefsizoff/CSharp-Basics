using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ArrayMatcher
{
    class ArrayMatcher
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string[] stringArray = input.Split('\\');

            char[] first = stringArray[0].ToCharArray();
            char[] second = stringArray[1].ToCharArray();


            //List<string> output = stringArray.ToList();

            

            //join
            if (stringArray[2] == "join")
            {
                var list3 = second.Where(i => first.Contains(i)).ToList();
                list3.Sort();
                foreach (var item in list3)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
            //left exclude
            else if (stringArray[2] == "left exclude")
            {
                var list2 = second.Where(i => !first.Contains(i)).ToList();
                list2.Sort();
                foreach (var item in list2)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
                //right exclude
            else
            {
                var list1 = first.Where(i => !second.Contains(i)).ToList();
                list1.Sort();
                foreach (var item in list1)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
        }
    }
}
