//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers:
//		a1, a2, … a10, such that 1 < a1 < … < a10 < 100


using System;
class ReadNumberMethod
{
    private static int[] ReadNumber(int start, int end)
    {
        int counter = 0;
        int[] enteredNumbers = new int[10];
        while (counter < 10)
        {
            try
            {
                Console.WriteLine("Enter number a{0}  ({1}<a{0}<{2}) = ", counter + 1, start, end);
                enteredNumbers[counter] = int.Parse(Console.ReadLine());
                if ((enteredNumbers[counter] <= start) || (enteredNumbers[counter] >= end))
                {
                    throw new ArithmeticException("The number you've entered is out of range");
                }
                start = enteredNumbers[counter];
                counter++;
            }
            catch (FormatException)
            {
                Console.WriteLine("You have to enter an integer number!");
                throw;
            }
            catch (OverflowException)
            {
                Console.WriteLine("The value you've entered is either too small or too big");
                throw;
            }
        }
        return enteredNumbers;
    }
    
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter start range S (0<S<90)= ");
            int start = int.Parse(Console.ReadLine());
            if ((start<1)||(start>89))
            {
                throw new ArithmeticException("You have entered wrong start range number");
            }
            Console.WriteLine("Enter end range E (s+10<S<101)= ");
            int end = int.Parse(Console.ReadLine());
            if ((end < start+11) || (end > 100))
            {
                throw new ArithmeticException("You have entered wrong end range number");
            }
            int[] enteredNumbers = ReadNumber(start, end);
            foreach (int number in enteredNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        catch (FormatException)
        {
            Console.WriteLine("You have to enter an integer number!");
            throw;
        }
        catch (OverflowException)
        {
            Console.WriteLine("The value you've entered is either too small or too big");
            throw;
        }
    }

   
}
