using System;

class HelloWorld
{
    static void Main()
    {
        string escapingQuotations = "The \"use\" of quotations causes difficulties";
        string quotedString = @"The ""use"" of quotations causes difficulties";
        Console.WriteLine(escapingQuotations);
        Console.WriteLine(quotedString);
    }
}

