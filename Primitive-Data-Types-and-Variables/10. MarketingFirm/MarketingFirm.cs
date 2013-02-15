using System;

class Program
{
    static void Main()
    {
        string firstName;
        string familyName;
        byte age;
        char gender;
        int idNumber;
        int uniqueEmployeeNumber;

        Console.WriteLine("Write the first name...");
        firstName = Console.ReadLine();
        Console.WriteLine("Write the family name...");
        familyName = Console.ReadLine();
        Console.WriteLine("Write the age...");
        age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Write the gander (m or f)...");
        gender = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Write the ID number...");
        idNumber  = int.Parse (Console.ReadLine());
        Console.WriteLine("Write the unique employee number...");
        uniqueEmployeeNumber = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Name: {0} {1}; age: {2}, gender: {3}, ID number: {4}, unique employee number : {5}",firstName, familyName, age, gender, idNumber, uniqueEmployeeNumber );
    }
}

