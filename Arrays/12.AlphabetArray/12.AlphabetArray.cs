using System;
class AlphabetArray
{
    static void Main()
    {
        // Write a program that creates an array containing all letters from the alphabet (A-Z). 
        // Read a word from the console and print the index of each of its letters in the array.

        //create the array
        int [] alphabetArray = new int[27];
        for (int i = 1, k=0; i < 27; i++, k++)
        {
            alphabetArray[i] = 'A' + k;
        }
        Console.Write("Please, write the word = ");
        string word = Console.ReadLine();
        string copyWord = word; // we want to save the original Word
        word = word.ToUpper();
        for (int i = 0; i < word.Length; i++)
        {
            bool thereIsLetter = false;
            for (int j = 0; j < alphabetArray.Length; j++)
            {
                if (word[i]==alphabetArray[j])
                {
                    Console.WriteLine("Letter {0} has index in our alphabet {1}", copyWord[i], j);
                    thereIsLetter = true;
                    break;
                }
            }
            if (!thereIsLetter)
            {
                Console.WriteLine("You have entered something that is not a letter");
            }
        }


    }
}

