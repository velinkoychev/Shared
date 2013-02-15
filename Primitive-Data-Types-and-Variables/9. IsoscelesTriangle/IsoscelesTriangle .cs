using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("{0,10}","\u00A9");
        Console.WriteLine("{0,8}{0,4}", "\u00A9");
        Console.WriteLine("{0,6}{0,8}", "\u00A9");
        Console.WriteLine("{0,4}{0,4}{0,4}{0,4}", "\u00A9");
    }
}

