using System;

class CalculateTheSum
{
    static void Main()
    {
        double oldSum = 1;
        double counter = 2;
        double newSum;
        double difference;
        do
        {
            if ((counter % 2) == 0)  //if counter is even
            {
                newSum = (oldSum + (1 / counter));
                difference = newSum - oldSum;
                counter++;
                oldSum = newSum;
            }
            else
            {
                newSum = (oldSum - (1 / counter)); // if counter is odd
                difference =Math.Abs(newSum - oldSum);
                counter++;
                oldSum = newSum;
            }
        }
        while (difference > 0.001); // we have reached the desired accuracy
        Console.WriteLine("The sum = {0}", newSum );
    }
}

