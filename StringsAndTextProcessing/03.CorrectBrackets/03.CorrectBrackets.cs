//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).


using System;
class CorrectBrackets 
{
    static void Main()
    {
        CheckExpression("((a+b)/5-d)");
        CheckExpression(")(a+b))");
        Console.Write("Please, write your expression = ");
        string expression = Console.ReadLine();
        CheckExpression(expression);
    }

    private static void CheckExpression(string expression)
    {
        int countOpeningBrackets = 0;
        int countClosingBrackets = 0;
        bool correctInput = true;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                countOpeningBrackets++;
            }
            if (expression[i] == ')')
            {
                countClosingBrackets++;
            }
            if (countClosingBrackets > countOpeningBrackets)
            {
                correctInput = false;
                break;
            }
        }
        if (countOpeningBrackets != countClosingBrackets)
        {
            correctInput = false;
        }
        if (correctInput)
        {
            Console.WriteLine("Correct expression!");
        }
        else
        {
            Console.WriteLine("Incorrect expression!");
        }
    }
}

