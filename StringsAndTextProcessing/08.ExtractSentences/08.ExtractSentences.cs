//Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Text;
using System.Text.RegularExpressions;
class ExtractSentences
{
    static string SearchAndExtractSentences(string enteredText, string searchWord)
    {
        StringBuilder extractedText = new StringBuilder();
        char [] delimiters = new char[] {'.'};
        string[] sentences = enteredText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        string pattern = @"\b"+searchWord +@"\b";
        foreach (string sentence in sentences)
        {
            //we will use .ToLower() to make sure that we are searching case insesitive
            //also to make things easier and shorter, we will use regular expressions. 
            Match match = Regex.Match(sentence.ToLower(), pattern.ToLower());
            if (match.Success)
            {
                extractedText.Append(sentence + '.');
            } 
        }
        

        return extractedText.ToString();
    }
    static void Main()
    {
        string enteredText = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string searchWord = "in";
        Console.WriteLine(SearchAndExtractSentences(enteredText, searchWord));
        Console.WriteLine("If you want to try yourself, please enter the text: ");
        enteredText = Console.ReadLine();
        Console.Write("And now the word you are searching for...");
        searchWord = Console.ReadLine();
        Console.WriteLine(SearchAndExtractSentences(enteredText, searchWord));
    }
}

