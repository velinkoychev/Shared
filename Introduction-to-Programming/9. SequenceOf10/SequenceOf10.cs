using System;

class Sequence
{
    static void Main()
    {
        int i = 0;
        int y = 2;
        while (i < 10)
        {
            Console.WriteLine(y);
            if (y > 0)
            {
                y = -1 * (y + 1);
                Console.WriteLine(y);
                i++;
            }
            if (y < 0)
            {
                y = -1 * (y - 1);
                i++;
            }
        }
    }
}

