//Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

using System;
class SquareRoot
{
    static void Main()
    {
        Console.Write("Please, enter the integer number = ");
        try
        {
            uint integerNumber = uint.Parse(Console.ReadLine());
            Console.WriteLine("The square root = {0}", Math.Sqrt((double)(integerNumber)));
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (System.OverflowException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
