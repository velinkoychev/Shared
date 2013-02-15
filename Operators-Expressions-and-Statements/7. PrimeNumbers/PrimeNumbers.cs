using System;
class PrimeNumbers
{
    static void Main()
    {
        int numberN;
        byte count=2;
        bool isItPrime=true;
        do
        {
            Console.WriteLine("Write positive number n (n<=100)");
            numberN = int.Parse(Console.ReadLine());
        }
        while ((numberN<1) || (numberN>100));
        do
        {
            if ((numberN % count) == 0)
            {
                isItPrime = false;
            }
            count++;
        }
        while (count <= Math.Sqrt(numberN));
        if ((numberN == 1) || (numberN == 2))
        {
            isItPrime = true;
        }
            Console.WriteLine(isItPrime ? "It is prime" : "It is not prime");
    }
}

    