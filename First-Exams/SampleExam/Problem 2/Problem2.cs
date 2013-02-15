using System;

class Problem2
{
    static void Main()
    {
        int[] cats = new int [10];
        int  numberN = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberN ; i++)
        {
            int vote = int.Parse(Console.ReadLine());
            cats[vote-1] = cats[vote-1] + 1;
        }
        int maxCat = 1;
        for (int i = 0; i < 9 ; i++)
        {
            if ((cats[i + 1]) > (cats[maxCat-1]))
            {
                maxCat = i + 2;
            }
        }
        Console.WriteLine(maxCat);
    }
}

