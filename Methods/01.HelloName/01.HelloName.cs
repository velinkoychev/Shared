﻿// Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.

using System;

class HelloName
{
    static void AskAndPrintName()
    {
        Console.Write("What is Your name?...  ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
    }
    static void Main()
    {
        AskAndPrintName();
    }
}

