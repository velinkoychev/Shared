using System;
class Sort3RealNumbers
{
    static void Main()
    {
        double realValue1, realValue2, realValue3;
        double tempValue; // to save temporary one of the values in order to switch the values of two of them
        Console.Write("Please, write the first real value = ");
        realValue1 = double.Parse(Console.ReadLine());
        Console.Write("Please, write the second real value = ");
        realValue2 = double.Parse(Console.ReadLine());
        Console.Write("Please, write the third real value = ");
        realValue3 = double.Parse(Console.ReadLine());

        if (realValue2 > realValue1)
        {
            tempValue = realValue1;
            realValue1 = realValue2;
            realValue2 = tempValue;
            if (realValue3 > realValue1) //this means that number 3 is the biggest and number 2 the smallest
            {
                tempValue = realValue1;
                realValue1 = realValue3;
                realValue3 = tempValue;
                tempValue = realValue2;
                realValue2 = realValue3;
                realValue3 = realValue2;
            }
            else if (realValue3 > realValue2)
            {
                tempValue = realValue2;
                realValue2 = realValue3;
                realValue3 = tempValue;
            }
        }
        else if (realValue3 > realValue1) //this means that number 3 is the biggest and number 2 the smallest
        {
            tempValue = realValue1;
            realValue1 = realValue3;
            realValue3 = tempValue;
            tempValue = realValue2;
            realValue2 = realValue3;
            realValue3 = realValue2;
        }
        else if (realValue3 > realValue2)
        {
            tempValue = realValue2;
            realValue2 = realValue3;
            realValue3 = tempValue;
        }
        Console.WriteLine("The order of the numbers is: 1) {0}; 2) {1}; 3) {2};", realValue1, realValue2, realValue3 );
    }
}

