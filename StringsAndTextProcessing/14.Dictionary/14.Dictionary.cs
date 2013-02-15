//A dictionary is stored as a sequence of text lines containing words and their explanations. 
//Write a program that enters a word and translates it by using the dictionary. 

using System;
using System.Text.RegularExpressions;
class Dictionary
{
    static void Main()
    {
        string[] dictionary = {
            ".NET - platform for applications from Microsoft",
            "CLR - managed execution environment for .NET",
            "namespace - hierarchical - organization of classes"
        };
        string searchingWord = "cLR";
        SearchInDictionary(dictionary, searchingWord);
        Console.Write("Enter the word you want to find definition = ");
        searchingWord = Console.ReadLine();
        SearchInDictionary(dictionary, searchingWord);
    }

    private static void SearchInDictionary(string[] dictionary, string searchingWord)
    {
        string regex = @"(.*?) - (.*)"; ////use regex to find the words and definitions 
        bool definitionFound = false;
        foreach (string line in dictionary)
        {
            var partsOfDictionary = Regex.Match(line, regex).Groups;

            if (Regex.IsMatch(partsOfDictionary[1].Value, searchingWord, RegexOptions.IgnoreCase))
            {
                Console.WriteLine("{0}:  {1}",partsOfDictionary[1], partsOfDictionary[2]);
                definitionFound = true;
                return;
            }
        }
        if (!definitionFound)
        {
            Console.WriteLine("Sorry, no definition was found");
        }
    }
}

