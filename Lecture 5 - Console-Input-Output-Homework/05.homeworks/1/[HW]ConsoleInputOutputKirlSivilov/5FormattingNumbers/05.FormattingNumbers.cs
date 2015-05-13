using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned.
      class Program
    {
        static void Main()
        {
            Console.Title = "FormattingNumbers";
            Console.Write("Enter first value (must be integer type and between 0 and 500): ");
            int var1;
            while(!int.TryParse(Console.ReadLine(), out var1) | var1 > 0 | var1 < 500)
            Console.WriteLine("TRY AGAIN!PLEASE ENTER NATURAL TYPE NUMBER!(example:0<=2,3,55...<=500)");
            Console.Write("Enter second value (must be floating type: 0.1, 0.33, 0.453..): ");
            double var2;
            while(!double.TryParse(Console.ReadLine(),out var2))
            Console.WriteLine("TRY AGAIN!PLEASE ENTER FLOATING TYPE NUMBER(USE '.')!(example:0.1, 0.33, 0.453)");
            Console.Write("Enter third value (must be floating type: 0.1, 0.33, 0.453..): ");
            double var3;
            while(!double.TryParse(Console.ReadLine(),out var3))
            Console.WriteLine("TRY AGAIN!PLEASE ENTER FLOATING TYPE NUMBER(USE '.')!(example:0.1, 0.33, 0.453)");
            string emptySpace = "";   //I've used this string to print the free space between columns;
            Console.WriteLine("|{0:X}{1,8}|{2}|{1,7}{3:0.00}|{4:0.000}{1,5}|",Convert.ToInt32(var1),emptySpace,Convert.ToString(var1, 2).PadLeft(10, '0'),var2,var3);


        }
    }

