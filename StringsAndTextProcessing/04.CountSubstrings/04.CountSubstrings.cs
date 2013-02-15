//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

using System;
class CountSubstrings
{
    static int SubstringCounter(string enteredText, string substring)
    {
        int counter = 0;
        int lastIndex = -1;
        do
        {
            lastIndex = enteredText.ToLower().IndexOf(substring.ToLower(), lastIndex + 1);
            if (lastIndex != -1)
            {
                counter++;
            }
        }
        while (lastIndex != -1);
        return counter;
    }
    static void Main()
    {
        string enteredText = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string substring = "in";
        Console.WriteLine("There are {0} times of \"{1}\" in the text", SubstringCounter(enteredText, substring), substring);
        Console.WriteLine("Please enter the text: ");
        enteredText = Console.ReadLine();
        Console.Write("Please enter the substring: ");
        substring = Console.ReadLine();
        Console.WriteLine("There are {0} times of {1} in the text", SubstringCounter(enteredText, substring), substring);
    }
}

