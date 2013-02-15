using System;

class Problem1
{
    static void Main()
    {
        int pX1 = int.Parse(Console.ReadLine());
        int pY1 = int.Parse(Console.ReadLine());
        int pX2 = int.Parse(Console.ReadLine());
        int pY2 = int.Parse(Console.ReadLine());
        int fX = int.Parse(Console.ReadLine());
        int fY = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int temp;
        if (pX1 < pX2)
        {
            temp = pX1;
            pX1 = pX2;
            pX2 = temp;
        }
        if (pY1 < pY2)
        {
            temp = pY1;
            pY1 = pY2;
            pY2 = temp;
        }
        int damage = 0;
        if (((fX + d) >= pX2) && ((fX + d) <= pX1))
        {
            if ((fY >= pY2) && (fY<= pY1))
            {
                damage = damage + 100;
            }
            if ((fY + 1>= pY2) && (fY+1 <= pY1))
            {
                damage = damage + 50;
            }
            if ((fY -1  >= pY2) && (fY - 1<= pY1))
            {
                damage = damage + 50;
            }
        }
        if (((fX + d+1) >= pX2) && ((fX + d+1) <= pX1))
        {
            if ((fY >= pY2) && (fY <= pY1))
            {
                damage = damage + 75;
            }
        }
        Console.WriteLine(damage + "%");
        
    }
}

