//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

class AlphabeticalOrderOfWords
{
   // I am using the code from task 22, because it is powerful enough to do this task much better than this exersise wants. 
   //otherwise it can easily be done with str.Split() and than Array.Sort() and print the array.
    
    static void Main()
    {
        string enteredText = "Just for the test. I am TESTING the test for TEST reasons. Of course, make your own testing, please!";
        SearchForLetters(enteredText);
        Console.WriteLine("Please, enter the text: ");
        enteredText = Console.ReadLine();
        SearchForLetters(enteredText);
    }

    private static void SearchForLetters(string enteredText)
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        string textToSearch = enteredText.ToLower();
        string pattern = @"\b\w+\b";
        Match match = Regex.Match(textToSearch, pattern);
        while (match.Success)
        {
            int value;
            //we will use TryGetValue because it is more efficient
            if (dictionary.TryGetValue(match.Value, out value))
            {
                dictionary[match.Value] = value + 1;
            }
            else
            {
                dictionary.Add(match.Value, 1);
            }
            match = match.NextMatch();
        }
        Console.WriteLine("The words in alphabetical order (By the way, if the word was 2 or more times in the text, it will be printed just once):");
        foreach (var item in dictionary.OrderBy(i => i.Key))
        {
            Console.WriteLine(item.Key);
        }

    }

}

