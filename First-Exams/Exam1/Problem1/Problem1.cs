using System;

class Problem1
{

    static void Main()
    {
        int[,] rectangular = new int[2, 4];
        for (int i = 0; i < 2; i++)    // assign the rectangle
        {
            for (int j = 0; j < 2; j++)
            {
                rectangular[j, i] = int.Parse(Console.ReadLine());
            }
        }
        if (rectangular[0,0] <rectangular[0,1])
        {
            int temp = rectangular[0,0];
            rectangular[0, 0] = rectangular[0, 1];
            rectangular[0, 1] = temp;
        }
        if (rectangular[1, 0] < rectangular[1, 1])
        {
            int temp = rectangular[1, 0];
            rectangular[1, 0] = rectangular[1, 1];
            rectangular[1, 1] = temp;
        }
        rectangular[0, 2] = rectangular[0, 0];
        rectangular[1, 2] = rectangular[1, 1];
        rectangular[0, 3] = rectangular[0, 1];
        rectangular[1, 3] = rectangular[1, 0];
        int h = int.Parse(Console.ReadLine());
        int[,] catapults = new int[2, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                catapults[j, i] = int.Parse(Console.ReadLine());
            }
        }
        int damage = 0;
        for (int i = 0; i < 3; i++)
        {
            catapults[1, i] = (h - catapults[1, i]) + h;
        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)  // Check the corners damage
            {
                if (catapults[0, i] == rectangular[0, j])
                {
                    if (catapults[1, i] == rectangular[1, j])
                    {
                        damage = damage + 25;
                    }
                }
            }
            // Check the borders damage
            if ((catapults[0, i] == rectangular[0, 0])||(catapults[0, i] == rectangular[0, 1]))
            {
                if ((catapults[1, i] < rectangular[1, 0]) && (catapults[1, i] > rectangular[1, 1]))
                    damage = damage + 50;
            }
            if ((catapults[1, i] == rectangular[1, 0]) || (catapults[1, i] == rectangular[1, 1]))
            {
                if ((catapults[0, i] < rectangular[0, 0]) && (catapults[0, i] > rectangular[0, 1]))
                    damage = damage + 50;
            }
            // Check the internal body damage
            if ((catapults[0, i] > rectangular[0, 1]) && (catapults[0, i] < rectangular[0, 0]))
            {
                if ((catapults[1, i] > rectangular[1, 1]) && (catapults[1, i] < rectangular[1, 0]))
                {
                    damage = damage + 100;
                }
            }
        }
        
        Console.WriteLine(damage+"%");
    }

}


