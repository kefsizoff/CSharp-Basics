using System;

class PrintCompanyInfo
{
    static void Main()
    {
        //A company has name, address, phone number, fax number, web site and manager. 
        //The manager has first name, last name, age and a phone number. 
        //Write a program that reads the information about a company and its manager and prints it back on the console.

        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string companyPhone = Console.ReadLine();
        Console.Write("Fax number: ");
        string companyFaxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string companyWebSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();

        if (companyFaxNumber == "")
        {
            companyFaxNumber = "(no fax)";
        }

        Console.WriteLine("\r\n\r\n");

        Console.WriteLine("Company name:        | {0}", companyName);
        Console.WriteLine("Company address:     | {0}", companyAddress);
        Console.WriteLine("Phone number:        | {0}", companyPhone);
        Console.WriteLine("Fax number:          | {0}", companyFaxNumber);
        Console.WriteLine("Web site:            | {0}", companyWebSite);
        Console.WriteLine("Manager first name:  | {0}", managerFirstName);
        Console.WriteLine("Manager last name:   | {0}", managerLastName);
        Console.WriteLine("Manager age:         | {0}", managerAge);
        Console.WriteLine("Manager phone:       | {0}", managerPhone);
    }
}