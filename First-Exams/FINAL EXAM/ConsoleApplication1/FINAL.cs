using System;
using System.Threading;
using System.Globalization;

class Problem3
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        bool thereIsSomething = false;
        int[] array = new int[16];
        for (int i = 0; i < 5; i++)
        {
            string readCard = Console.ReadLine();
            switch (readCard)
            {
                case "A":
                    array[14]++;
                    array[1]++;
                    break;
                case "J":
                    array[11]++;
                    break;
                case "Q":
                    array[12]++;
                    break;
                case "K":
                    array[13]++;
                    break;
                default:
                    int number = int.Parse(readCard);
                    array[number]++; break;
            }
        }
        for (int i = 0; i < 16; i++)
        {
            if (array[i] == 5)
            {
                Console.WriteLine("Impossible");
                thereIsSomething = true;
                break;
            }
            if (array[i] == 4)
            {
                Console.WriteLine("Four of a Kind");
                thereIsSomething = true;
                break;
            }
            if (array[i] == 3)
            {
                bool thereIsPair = false;
                for (int j = 0; j < 16; j++)
                {
                    if (array[j] == 2)
                    {
                        thereIsPair = true;
                    }
                }
                if (thereIsPair)
                {
                    Console.WriteLine("Full House");
                }
                else
                {
                    Console.WriteLine("Three of a Kind");
                }
                thereIsSomething = true;
                break;
            }
            if ((array[i] == 2) && (i != 1))
            {
                bool thereIsPair = false;
                for (int j = 0; j < 16; j++)
                {
                    if ((array[j] == 2)&& (i!=j))
                    {
                        thereIsPair = true;
                    }
                }
                if (thereIsPair)
                {
                    Console.WriteLine("Two Pairs");
                }
                else
                {
                    Console.WriteLine("One Pair");
                }
                thereIsSomething = true;
                break;
            }
        }
        int counter = 0;
        for (int i = 0; i < 16; i++)
        {
            if (array[i] == 1)
            {
                counter++;
            }
            else
            {
                if (counter == 5)
                {
                    Console.WriteLine("Straight");
                    thereIsSomething = true;
                    break;
                }
                counter = 0;
            }
        }
        if (!thereIsSomething )
        {
            Console.WriteLine("Nothing");
        }

    }
}