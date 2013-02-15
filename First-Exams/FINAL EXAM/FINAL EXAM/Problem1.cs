using System;
using System.Threading;
using System.Globalization;

class Problem1
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        char [] array = new char [6];
        int readDigit = -1;
        int counter = 0;
        while ((readDigit != 13) && (readDigit != 10))
        {
            if ((readDigit != 46) && (readDigit != 45) && (readDigit != -1))  // we don't need to read only '.' and '-'
            {
                array[counter] = (char)readDigit;
                counter++;
            }
            readDigit = Console.Read();
        }
        int newCounter = counter;
        for (int i = 0; i < 3; i++)
        {
            if (array[counter-1] == '0')
            {
                counter--;  
            }
            else if (array[counter - 1] != '0')
            {
                char temp = array[counter - 1];
                for (int j = counter - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = temp;
            }
            
        }
        for (int i = 0; i < counter; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
    }
}

