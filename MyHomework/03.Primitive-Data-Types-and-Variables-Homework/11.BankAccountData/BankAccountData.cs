using System;

//Problem 11.	Bank Account Data
//A bank account has a holder name (first name, middle name and last name),
//available amount of money (balance), bank name, IBAN, 3 credit card 
//numbers associated with the account. Declare the variables needed to
//keep the information for a single bank account using the 
//appropriate data types and descriptive names.


class BankAccountData
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Petrov";
        string lastName = "Ivanov";
        string holderName = (firstName + " " + middleName + " " + lastName);
        decimal balance = 34344334344480483294828083424m;
        string bankName = "FIB";
        string iban = "39 FINV 9150 1003 5487 97";
        ulong cardNumber1 = 1200039131294395;
        ulong cardNumber2 = 1200039131294543;
        ulong cardNumber3 = 1200039131294121;

        Console.WriteLine("Holder Name: {0}", holderName);
        Console.WriteLine("Balance: {0}$", balance);
        Console.WriteLine("Bank: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("Card Number 1: {0}", cardNumber1);
        Console.WriteLine("Card Number 2: {0}", cardNumber2);
        Console.WriteLine("Card Number 3: {0}", cardNumber3);
    }
}
