using System;


//A company has name, address, phone number, fax number, web site and manager.
//The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and 
//prints it back on the console.



class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Company name:");
        string company = Console.ReadLine();
        Console.Write("Company address:");
        string compAddress = Console.ReadLine();
        Console.Write("Company Phone:");
        string companyPhone = Console.ReadLine();
        Console.Write("Company Fax:");
        string companyFax = Console.ReadLine();

        string fax = ((companyFax == "") ? "no fax" : companyFax);

        Console.Write("Company website:");
        string companyWebsite = Console.ReadLine();

        Console.Write("Manager first name:");
        string managerFirstName = Console.ReadLine();

        Console.Write("Manager last name:");
        string managerLastName = Console.ReadLine();

        Console.Write("Manager age:");
        byte managerAge = byte.Parse(Console.ReadLine());

        Console.Write("Manager phone number:");
        string managerPhone = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Company name: {0}", company);
        Console.WriteLine("Company Address: {0}", compAddress);
        Console.WriteLine("Phone number: {0}", companyPhone);
        Console.WriteLine("Fax number: {0}", fax);
        Console.WriteLine("Web site:{0}", companyWebsite);
        Console.WriteLine("Manager first name: {0}", managerFirstName);
        Console.WriteLine("Manager last name: {0}", managerLastName);
        Console.WriteLine("Manager age: {0}", managerAge);
        Console.WriteLine("Manager phone: {0}", managerPhone);
       
    }
}
