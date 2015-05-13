using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints it back on the console.
    class Program
    {
        static void Main()
        {
            Console.Title="PrintCompanyInformation";
            Console.Write("Enter company name: ");
            string companyName=Console.ReadLine();
            Console.Write("Enter comapny andress: ");
            string address=Console.ReadLine();
            Console.Write("Enter the comapny phone number: ");
            string phoneNumber=Console.ReadLine();
            Console.Write("Enter fax: ");
            string fax = Console.ReadLine();
            Console.Write("Enter web site: ");
            string website = Console.ReadLine();
            Console.Write("Enter manager first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter manager last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter manager age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter manager phone number: ");
            string phone=Console.ReadLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Company name: {0} \n Adress: {1} \n Tel: {2} \n Fax: {3} \n Web Site: {4} \n )"+
                "Manager: {5} {6} (age: \n {7} ,tel: {8})",companyName,address,phoneNumber,fax,website,firstName,lastName,age,phone);

        }
    }

