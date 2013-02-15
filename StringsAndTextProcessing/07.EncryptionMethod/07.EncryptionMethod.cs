//Write a program that encodes and decodes a string using given encryption key (cipher). 
//The key consists of a sequence of characters. The encoding/decoding is done by performing 
//XOR (exclusive or) operation over the first letter of the string with the first of the key, 
//the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Text;
class EncryptionMethod
{
    static string EncodeOrDecode(string enteredText, string encryptionKey)
    {
        StringBuilder newText = new StringBuilder();
        for (int i = 0, key=0; i < enteredText.Length; i++, key++)
        {
            if (key==encryptionKey.Length)
            {
                key = 0;
            }
            newText.Append((char)(enteredText[i] ^ encryptionKey[key]));
        }
        return newText.ToString();
    }

    static void Main()
    {
        string encryptionKey = "@d%fk6$;#!=d";
        string enteredText = "Encode this text";
        Console.WriteLine("Test of the program. Now we will encode this text:");
        Console.WriteLine(enteredText);
        enteredText = ReadData(encryptionKey, enteredText);
        Console.Write("If you want to test the program, please enter encryption key= ");
        encryptionKey = Console.ReadLine();
        Console.Write("Please, enter the string you want to encode = ");
        enteredText = Console.ReadLine();
        enteredText = ReadData(encryptionKey, enteredText);

    }

    private static string ReadData(string encryptionKey, string enteredText)
    {
        Console.WriteLine("The encoded text:");
        string encodedText = EncodeOrDecode(enteredText, encryptionKey);
        Console.WriteLine(encodedText);
        Console.WriteLine("And again, the text decoded:");
        enteredText = EncodeOrDecode(encodedText, encryptionKey);
        Console.WriteLine(enteredText);
        return enteredText;
    }
}

