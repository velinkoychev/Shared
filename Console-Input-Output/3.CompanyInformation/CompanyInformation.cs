using System;
class CompanyInformation
{
    static void Main()
    {
        string companyName, companyAddress, companyWebsite, managerFirstName, managerLastName; 
        byte managerAge;
        ulong companyPhoneNumber, companyFaxNumber, managerPhoneNumber;
        Console.Write("Write the name of the company...");
        companyName = Console.ReadLine();
        Console.Write("Write the address of the company...");
        companyAddress = Console.ReadLine();
        Console.Write("Write the phone number of the company...");
        companyPhoneNumber =ulong.Parse(Console.ReadLine());
        Console.Write("Write the fax number of the company...");
        companyFaxNumber = ulong.Parse(Console.ReadLine());
        Console.Write("Write the web site of the company...");
        companyWebsite = Console.ReadLine();
        Console.Write("Write the first name of the manager of the company...");
        managerFirstName = Console.ReadLine();
        Console.Write("Write the last name of the manager of the company...");
        managerLastName = Console.ReadLine();
        Console.Write("Write the age of the manager...");
        managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Write the phone number of the manager...");
        managerPhoneNumber = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Company name: {0}; address : {1}; phone number : {2} fax number : {3} web site : {4}", companyName, companyAddress, companyPhoneNumber, companyFaxNumber, companyWebsite );
        Console.WriteLine("Maneger of the company : {0} {1}; age : {2}; phone number: {3}", managerFirstName, managerLastName, managerAge, managerPhoneNumber  );
    }
}

