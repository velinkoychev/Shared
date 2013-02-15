//Write a program for extracting all email addresses from given text.
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class ExtractEmailAddresses
{
    static void Main()
    {
        string textWithEmails = "test.email.just.for.fun@mail.co.uk //test@mail.com/ **example@abv.bg And now some WRONG emails: @telerik.com test@test. a@a.b.";
        SearchForEmails(textWithEmails);
        Console.WriteLine("Please, enter the text with emails: ");
        textWithEmails = Console.ReadLine();
        SearchForEmails(textWithEmails);
    }

    private static void SearchForEmails(string textWithEmails)
    {
        string pattern = @"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)";
        Match match = Regex.Match(textWithEmails, pattern);
        List<string> foundEmails = new List<string>();
        while (match.Success)
        {
            foundEmails.Add(match.Value);
            match = match.NextMatch();
        }
        foreach (string email in foundEmails)
        {
            Console.WriteLine(email);
        }
    }
}
