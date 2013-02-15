using System;

class Problem2
{
    static void Main()
    {
        int[] numbersArray = new int[5];
        for (int i = 0; i < 5; i++)
        {
            numbersArray[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbersArray);
        int answer = 1000001;
        int temp1, temp2, temp3;
        for (int i = 0; i <= 2; i++)
        {
            for (int j = i + 1; j <= 3; j++)
            {
                for (int z = j + 1; z <= 4; z++)
                {
                    temp1 = numbersArray[i];
                    temp2 = numbersArray[j];
                    temp3 = numbersArray[z];
                    int gcd = 1;
                    while (temp1 != 0 && temp2 != 0)
                    {
                        if (temp1 > temp2)
                            temp1 = temp1 % temp2;
                        else
                            temp2 = temp2 % temp1;
                    }
                    if (temp1 == 0)
                        gcd = temp2;
                    else
                        gcd = temp1;
                    int temp12 = gcd * (numbersArray[i] / gcd) * (numbersArray [j] / gcd);
                    int temp12old=temp12;
                    while (temp12 != 0 && temp3 != 0)
                    {
                        if (temp12 > temp3)
                            temp12 = temp12 % temp3;
                        else
                            temp3 = temp3 % temp12;
                    }
                    if (temp12 == 0)
                        gcd = temp3;
                    else
                        gcd = temp12;
                    if ( answer > (gcd * (temp12old / gcd)* (numbersArray[z]/gcd)))
                    {
                        answer = gcd * (temp12old / gcd) * (numbersArray[z] / gcd);
                    }
                }
            }

        }

        Console.WriteLine(answer);
    }
}

