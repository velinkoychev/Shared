using System;
using System.Collections.Generic;
using System.Text;

class State
{
    public string Obtained { get; set; }
    public string Left { get; set; }
}

class CipherElement
{
    public string Letter { get; set; }
    public string Digits { get; set; }
}

class MessagesInBottle
{
    static void Main()
    {
        string code = Console.ReadLine();
        string cipherToDecode = Console.ReadLine();
        List<CipherElement> cipher = BuildCipher(cipherToDecode);
        List<string> results = new List<string>();
        List<State> states = new List<State>();
        states.Add(new State() { Obtained = "", Left = code });
        int index= 0;
        while (index < states.Count)
        {
            State currentState = states [index];
            index++;
            foreach (var cipherElement in cipher)
            {
                if (currentState.Left.StartsWith (cipherElement.Digits))
                {
                    State newState = new State();
                    newState.Obtained = currentState.Obtained + cipherElement.Letter;
                    newState.Left = currentState.Left.Remove(0, cipherElement.Digits.Length);
                    if (newState.Left == "")
                    {
                        results.Add(newState.Obtained);
                    }
                    else
                    {
                        states.Add(newState);
                    }
                }
            }
        }
        Console.WriteLine(results.Count);
        results.Sort();
        foreach (var decodedLetters in results)
        {
            Console.WriteLine(decodedLetters);
        }
    }

    private static List<CipherElement> BuildCipher(string cipherToDecode)
    {
        List<CipherElement> elements = new List<CipherElement>();
        char? letter = null;
        StringBuilder digits = new StringBuilder();
        cipherToDecode += "Z";
        foreach (var ch in cipherToDecode)
        {
            if (char.IsLetter(ch))
            {
                if (letter != null)
                {
                    CipherElement newElement = new CipherElement();
                    newElement.Letter = Convert.ToString(letter.Value);
                    newElement.Digits = digits.ToString();
                    elements.Add(newElement);
                    digits.Clear();

                }
                letter = ch; 
            }
            else
            {
                digits.Append(ch);
            }
        }
        return elements; 
    }
}

