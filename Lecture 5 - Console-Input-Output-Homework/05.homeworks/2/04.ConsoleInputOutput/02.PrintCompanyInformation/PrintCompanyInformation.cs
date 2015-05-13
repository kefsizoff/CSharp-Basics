using System;


class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name:");
        string name = (Console.ReadLine());

        Console.Write("Company adress:");
        string adress = (Console.ReadLine());

        Console.Write("Phone number:");
        int phone = int.Parse(Console.ReadLine());

        Console.Write("Fax number:");
        int fax = int.Parse(Console.ReadLine());

        Console.Write("Web site:");
        string site = (Console.ReadLine());

        Console.Write("Manager First Name:");
        string firstName = (Console.ReadLine());

        Console.Write("Manager Last Name:");
        string lastName = (Console.ReadLine());

        Console.Write("Manager Age:");
        byte age = byte.Parse(Console.ReadLine());

        Console.Write("Manager number:");
        int managerPhone = int.Parse(Console.ReadLine());
        Console.WriteLine("\r\n");

        Console.WriteLine("{0}\r\nCompany adress: {1}\r\nTel: {2}\r\nFax: {3}\r\nWeb Site: {4}\r\nManager: {5}{6}(age: {7}, tel: {8})", 
           name, adress, phone, fax, site, firstName, lastName, age, managerPhone );
        Console.ReadLine();


        
     

    }
}

