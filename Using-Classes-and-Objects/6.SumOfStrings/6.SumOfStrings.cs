//You are given a sequence of positive integer values written into a string, separated by spaces. 
//Write a function that reads these values from given string and calculates their sum. Example:
//	string = "43 68 9 23 318"  result = 461


using System;
class SumOfStrings
{
    static void Main()
    {
        string separetedIntegerValues;
        Console.Write("Please, enter the integer values...  ");
        separetedIntegerValues = Console.ReadLine();
        string[] integerValues = separetedIntegerValues.Split(' ');
        int result = 0;
        foreach (string values in integerValues)
        {
            result = result + Int32.Parse(values);
        }
        Console.WriteLine("The sum of the integers = {0}", result);
    }
}

