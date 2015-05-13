using System;


//Problem 10.	Employee Data
//A marketing company wants to keep record of its employees. 
//Each record would have the following characteristics:
//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender (m or f)
//•	Personal ID number (e.g. 8306112507)
//•	Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee 
//using appropriate primitive data types. 
//Use descriptive names. Print the data at the console.


class EmployeeData
{
    static void Main()
    {
        string firstName = "Ivan";
        string lastName = "Ivanov";
        uint age = 31;
        char gender = 'm';
        ulong iDNumber = 8306112507u;
        ulong uniqueEmplNum = 27560000u;

        Console.WriteLine("Name: {0} {1}", firstName, lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Personal ID number: " + iDNumber);
        Console.WriteLine("Unique employee number: " + uniqueEmplNum);
    }
}
