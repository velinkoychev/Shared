//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;
using System.Collections.Generic;

class Palindromes
{
    static void Main()
    {
        string textWithPalindromes = @"ABBA test not lamal exe wrong";
        SearchForPalindromes(textWithPalindromes);
        Console.WriteLine("Please, enter the text with palindromes: ");
        textWithPalindromes = Console.ReadLine();
        SearchForPalindromes(textWithPalindromes);
    }

    private static void SearchForPalindromes(string textWithPalindromes)
    {
        List<string> palindromes = new List<string>();
        //first will split the text to words
        char[] delimiters = new char[] { '.', ' ', ';', ',' };
        string[] wordsInText = textWithPalindromes.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in wordsInText)
        {
            bool wordIsPalindrom = true;
            for (int i = 0, j=word.Length-1; i < word.Length/2; i++, j--)
            {
                if (word[i] != word[j])
                {
                    wordIsPalindrom = false;
                    break;
                }
            }
            if (wordIsPalindrom)
            {
                palindromes.Add(word);
            }
        }
        Console.WriteLine("There are {0} palindromes in the text:",palindromes.Count);
        foreach (string palindrom in palindromes)
        {
            Console.WriteLine(palindrom);
        }
    }
}

