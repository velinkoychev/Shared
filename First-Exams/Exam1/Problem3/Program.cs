using System;

class Program
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());


        for (int i = 0; i < numberN - 1; i++)
        {
            for (int j = 0; j < numberN - 2 - i; j++)
            {
                Console.Write(".");
            }
            for (int j = 0; j < 2*i+1; j++)
            {
                Console.Write("*");  
            }
            
            for (int j = 0; j < numberN - 2 - i; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();  
        }
        for (int j = 0; j < numberN - 2; j++)
        {
            Console.Write(".");
        }
            Console.Write("*");

        for (int j = 0; j < numberN - 2; j++)
        {
            Console.Write(".");
        }
        Console.WriteLine();
        

        

    }
}

