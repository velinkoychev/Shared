using System;
class BankAccount
{
    static void Main()
    {
        string firstName, middleName, lastName, bankName, iban, bicCode; 
        decimal availableMoney;
        ulong creditCard1, creditCard2, creditCard3;
        Console.WriteLine("Write the first name...");
        firstName = Console.ReadLine();
        Console.WriteLine("Write the middle name...");
        middleName = Console.ReadLine();
        Console.WriteLine("Write the last name...");
        lastName = Console.ReadLine();
        Console.WriteLine("Write the name of the bank...");
        bankName = Console.ReadLine();
        Console.WriteLine("Write the IBAN...");
        iban = Console.ReadLine();
        Console.WriteLine("Write the BIC code...");
        bicCode = Console.ReadLine();
        Console.WriteLine("Write the available amount of money");
        decimal.TryParse(Console.ReadLine(), out availableMoney);
        Console.WriteLine("Write the first credit card number");
        ulong.TryParse(Console.ReadLine(), out creditCard1);
        Console.WriteLine("Write the second credit card number");
        ulong.TryParse(Console.ReadLine(), out creditCard2);
        Console.WriteLine("Write the third credit card number");
        ulong.TryParse(Console.ReadLine(), out creditCard3);
        Console.WriteLine("Name: {0} {1} {2};", firstName, middleName, lastName );
        Console.WriteLine("Bank name: {0}, BIC code: {1}, IBAN: {2}, Available amount of money: {3}", bankName, bicCode,iban,availableMoney);
        Console.WriteLine("Credit card numbers: {0}; {1}; {2};", creditCard1, creditCard2, creditCard3);
    }
}

