using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
    class Program
    {
        static void Main()
        {
            Console.Title = "CirclePerimeterAndArea";
            Console.Write("Enter the radius of the circle: ");
            string radius=Console.ReadLine();                       //use "."as a decimal symbol,cause "," will inflict error.
            float test;                                           //This is a test value  for TryParse check.
            float numPi=3.14f;
            if(float.TryParse(radius,out test))                   //TryParse method to check if the input is correct.
            {
                Console.Write("");
            }
             else
            {
             Console.WriteLine("TRY AGAIN.PLEASE ENTER CORRECT PARAMETER(EXAMPLE:3.53)!");  
            }
              float radius1=float.Parse(radius);                //ive converted the radius from string to float.
              float area=(numPi*(radius1*radius1));
              float perimeter=(2*numPi*radius1);
              Console.WriteLine("The area of a circle is : {0:F2}cm2\n The perimeter of a circle is: {1:0.00} cm",area,perimeter);

                
        }
    }

