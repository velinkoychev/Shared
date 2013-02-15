using System;
using System.Threading;
using System.Globalization;

class Problem3
{
    static int[] array = new int[16];
    static bool thereIsSomething = false;
    static void Read()
    {
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
    }

    static void Impossible()
    {
        for (int i = 0; i < 15; i++)
        {
            if (array[i] == 5)
            {
                Console.WriteLine("Impossible");
                thereIsSomething = true;
                break;
            }
        }
    }
    static void FourOfaKind()
    {
        for (int i = 0; i < 15; i++)
        {
            if (array[i] == 4)
            {
                Console.WriteLine("Four of a Kind");
                thereIsSomething = true;
                break;
            }
        }
    }
    static void ThreeEqualCards()
    {
        for (int i = 0; i < 15; i++)
        {
            if (array[i] == 3)
            {
                bool thereIsPair = false;
                for (int j = 0; j < 15; j++)
                {
                    if (array[j] == 2)
                    {
                        thereIsPair = true;
                    }
                }
                if (thereIsPair)
                {
                    Console.WriteLine("Full House");
                    thereIsSomething = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Three of a Kind");
                    thereIsSomething = true;
                    break;
                }
            }
        }
    }
    static void TwoEqualCards()
    {
        for (int i = 0; i < 15; i++)
        {
            if ((array[i] == 2) && (i != 1))
            {
                bool thereIsPair = false;
                for (int j = 2; j < 16; j++)
                {
                    if ((array[j] == 2) && (j != i))
                    {
                        thereIsPair = true;
                    }
                }
                if (thereIsPair)
                {
                    Console.WriteLine("Two Pairs");
                    thereIsSomething = true;
                    break;
                }
                else
                {
                    Console.WriteLine("One Pair");
                    thereIsSomething = true;
                    break;
                }
            }
        }
    }
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Read();
        Impossible();
        if (!thereIsSomething )
        {
            FourOfaKind();
        }
        if (!thereIsSomething)
        {
            ThreeEqualCards();
        }
        if (!thereIsSomething)
        {
            TwoEqualCards ();
        }

        int counter = 0;
        for (int i = 1; i < 16; i++)
        {
            if (array[i] == 1)
            {
                counter++;
            }
            if (array[i] != 1)
            {
                if (counter == 5)
                {
                    Console.WriteLine("Straight");
                    thereIsSomething = true;
                }
                counter = 0;
            }
        }
        if (!thereIsSomething)
        {
            Console.WriteLine("Nothing");
        }

    }
}