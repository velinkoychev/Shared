//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//		Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//	Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0


using System;
class SolveProgram
{
    static int counterOfVisits = 0;
    static void ReverseDigits()
    {
        Console.Write("Please, enter the number you want to reverse: ");
        string numberToReverse = Console.ReadLine();
        int reversedNumber = 0;
        if (numberToReverse[0] == '-') //// we want to check if the number is negative
        {
            ReverseDigits();
        }
        for (int i = 0, power = 0; i < numberToReverse.Length; i++, power++)
        {
            
            reversedNumber = reversedNumber + (Convert.ToInt32(numberToReverse[i]) - 48) * (int)Math.Pow(10, power);
            //we are using Math.Pow because the program is small and don't require that much quickness

        }
        Console.WriteLine(reversedNumber);
        Main();
    }
    static void AvarageOfSequence()
    {
        // Enter the lenght of the sequence and enter the numbers 

        int sequenceLength = 0;
        bool correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter the length of the array = ");
            correctInput = int.TryParse(Console.ReadLine(), out sequenceLength);
            if (sequenceLength<=0)
            {
                Console.WriteLine("The sequence should not be empty");
                correctInput = false;
            }
        }
        // enter the sequence
        decimal[] sequenceOfIntegers = new decimal[sequenceLength];
        decimal counter = 0;
        decimal sumOfElements = 0;
        for (int i = 0; i < sequenceLength; i++)
        {
            Console.Write("Array[{0}] = ", i);
            correctInput = decimal.TryParse(Console.ReadLine(), out sequenceOfIntegers[i]);
            counter++;
            sumOfElements = sumOfElements + sequenceOfIntegers[i];
        }
        decimal avarage = sumOfElements / counter;
        Console.WriteLine("The avarage of the sequence is {0} ", avarage);
        Main();
    }
    static void SolveEquation()
    {
        decimal coefficientA = 0;
        decimal coefficientB = 0;
        bool correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter the coefficients of the equation. a= ");
            correctInput = decimal.TryParse(Console.ReadLine(), out coefficientA);
            if (coefficientA ==0)
            {
                Console.WriteLine("Coefficient a can't be 0");
                correctInput = false;
            }
        }
        correctInput = false;
        while (!correctInput)
        {
            Console.Write("b= ");
            correctInput = decimal.TryParse(Console.ReadLine(), out coefficientB);
        }
        decimal result = -coefficientB / coefficientA;
        Console.WriteLine("x= " + result);
        Main();

    }

    static void Main()
    {
        int option = 0;
        if (counterOfVisits == 0)
        {
            Console.WriteLine("Welcome, stranger! Take a look at our menu:");
        }
        counterOfVisits++;
        Console.WriteLine("+---------------------------------------------------+");
        Console.WriteLine(" 1. Reverse the digits of a number.                 |");
        Console.WriteLine(" 2. Calculate the avarage of a sequence of integers.|");
        Console.WriteLine(" 3. Solve a linear equation a * x + b = 0 .         |");
        Console.WriteLine(" 4. Exit                                            |");
        Console.WriteLine("+---------------------------------------------------+");
        bool correctInput = false;
        while (!correctInput)
        {
            Console.Write("Choose a task number: ");
            correctInput = int.TryParse(Console.ReadLine(), out option);
            if ((option > 4) || (option < 1))
            {
                correctInput = false;
            }
        }
        switch (option)
        {
            case 1:
                ReverseDigits();
                break;
            case 2:
                AvarageOfSequence();
                break;
            case 3:
                SolveEquation();
                break;
            case 4:
                Console.WriteLine("Good-bey, stranger!");
                break;
        }

    }
}

