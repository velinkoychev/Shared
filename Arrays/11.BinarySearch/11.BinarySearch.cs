using System;
class Program
{
    static void Main()
    {
        //Write a program that finds the index of given element in a sorted array of integers 
        //by using the binary search algorithm (find it in Wikipedia).

        // Enter the lenght of the array and check if is entered correctly

        int arrayLength = 0;
        int elementS = int.MinValue;
        bool correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter the length of the array = ");
            correctInput = int.TryParse(Console.ReadLine(), out arrayLength);
        }
        correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter the element that you search for = ");
            correctInput = int.TryParse(Console.ReadLine(), out elementS);
        }
        correctInput = false;
        // enter the array while checking if the entered values are correct
        int[] arrayOfIntegers = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            while (!correctInput)
            {
                Console.Write("Array[{0}] = ", i);
                correctInput = int.TryParse(Console.ReadLine(), out arrayOfIntegers[i]);
            }
            correctInput = false;
        }

        Array.Sort(arrayOfIntegers); //sort the array

        bool ElementNotFound = true; // check if we have found the element
        int checkIndex = ((arrayLength - 1)/ 2);
        int counter = arrayLength / 2;  // counter to make sure we don't go to INFINITE loop
        int maxValue = arrayLength - 1;
        int minValue = 0;
        while ((ElementNotFound)&&(counter>=0))
        {
            if (arrayOfIntegers[checkIndex] == elementS)
            {
                Console.WriteLine("The index of the element = {0}", checkIndex);
                ElementNotFound = false;
            }
            else if (arrayOfIntegers[checkIndex] < elementS)
            {
                minValue = checkIndex+1;
                checkIndex = (maxValue + minValue) / 2;
                
            }
            else if (arrayOfIntegers[checkIndex] > elementS)
            {
                maxValue = checkIndex-1;
                checkIndex = (maxValue + minValue) / 2;
            }
            counter--;
        }
        if (ElementNotFound) // if we haven't found any element
        {
            Console.WriteLine("Sorry, I coudn't find such an element!");
        }
    }
}
