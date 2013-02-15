using System;

class SubtractionAndMultiplicationOfPolynomials
{
    static decimal[] SumPolynomials(decimal[] polynomial1, decimal[] polynomial2)
    {
        decimal[] sumofPolynomials = new decimal[Math.Max(polynomial1.Length, polynomial2.Length)];
        for (int i = 0; i < sumofPolynomials.Length; i++)
        {
            // first check if there is a number at this index and then add it to the sum
            if (polynomial1.Length > i)
            {
                sumofPolynomials[i] = polynomial1[i] + sumofPolynomials[i];
            }
            if (polynomial2.Length > i)
            {
                sumofPolynomials[i] = polynomial2[i] + sumofPolynomials[i];
            }
        }
        return sumofPolynomials;
    }

    static decimal[] SubtractionPolynomials(decimal[] polynomial1, decimal[] polynomial2)
    {
        decimal[] subtractionofPolynomials = new decimal[Math.Max(polynomial1.Length, polynomial2.Length)];
        for (int i = 0; i < subtractionofPolynomials.Length; i++)
        {
            // first check if there is a number at this index and then add it to the sum
            if (polynomial1.Length > i)
            {
                subtractionofPolynomials[i] = polynomial1[i] + subtractionofPolynomials[i];
            }
            if (polynomial2.Length > i)
            {
                subtractionofPolynomials[i] = subtractionofPolynomials[i] - polynomial2[i];
            }
        }
        return subtractionofPolynomials;
    }
    static decimal[] MultiplcationPolynomials(decimal[] polynomial1, decimal[] polynomial2)
    {
        decimal[] multiplicationOfPolynomials = new decimal[polynomial1.Length + polynomial2.Length];
        for (int i = 0; i < polynomial1.Length; i++)
        {
            for (int j = 0; j < polynomial2.Length; j++)
            {
                int index = i + j;
                multiplicationOfPolynomials[index] += (polynomial1[i] * polynomial2[j]);
            }
        }
        return multiplicationOfPolynomials;
    }

    static void PrintPolynomial(decimal[] polynomial)
    {
        int counter = 0;
        for (int i = polynomial.Length - 1; i > 0; i--)
        {
            if (polynomial[i] > 0)
            {
                if (counter != 0)
                {
                    Console.Write("+{0}X^{1} ", polynomial[i], i);
                }
                if (counter == 0)
                {
                    Console.Write("{0}X^{1} ", polynomial[i], i);
                }
                counter++;
            }
            if (polynomial[i] < 0)
            {
                Console.Write("{0}X^{1} ", polynomial[i], i);
                counter++;
            }
        }
        if ((polynomial[0] > 0) && (counter != 0))
        {
            Console.WriteLine("+{0} ", polynomial[0]);
        }
        else
        {
            Console.WriteLine("{0}X", polynomial[0]);
        }
    }

    static void Main()
    {
        // In this task we need to write only the methods, but if you want to test with different polynomials,
        // just change the one I have written below
        decimal[] polynomial1 = { 3, 0, -68, 8, 9 };
        decimal[] polynomial2 = { 1, 52, 61, 8 };
        Console.Write("Polynomial 1 = ");
        PrintPolynomial(polynomial1);
        Console.Write("Polynomial 2 = ");
        PrintPolynomial(polynomial2);
        Console.Write("The sum = ");
        PrintPolynomial(SumPolynomials(polynomial1, polynomial2));
        //we will subtract from the 1st polynomial the 2nd one
        Console.Write("The subtraction = ");
        PrintPolynomial(SubtractionPolynomials(polynomial1, polynomial2));
        Console.Write("The multiplication = ");
        PrintPolynomial(MultiplcationPolynomials(polynomial1, polynomial2));
    }
}


