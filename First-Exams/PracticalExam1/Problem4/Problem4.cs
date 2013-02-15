using System;

    class Problem4
    {
        static void Main()
        {
            int numberN = int.Parse(Console.ReadLine());
            long answer = 0;
            for (int i = 0; i < numberN ; i++)
            {
                long tempNumber = long.Parse(Console.ReadLine());
                answer = answer ^ tempNumber;
            }
            Console.WriteLine(answer);
        }
    }

