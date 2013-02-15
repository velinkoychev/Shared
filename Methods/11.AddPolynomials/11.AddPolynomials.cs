//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//		x2 + 5 = 1x2 + 0x + 5 


using System;
class AddPolynomials
{
    static decimal[] SumPolynomials(decimal[] polynomial1, decimal[] polynomial2)
    {
        decimal[] sumofPolynomials = new decimal[Math.Max(polynomial1.Length, polynomial2.Length)];
        for (int i = 0; i < sumofPolynomials.Length; i++)
        {
            // first check if there is a number at this index and then add it to the sum
            if (polynomial1.Length>i)
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
    static void PrintPolynomial(decimal[] polynomial)
    {
        for (int i = polynomial.Length - 1; i >= 1; i--)
        {
            if (polynomial[i] != 0)
            {
                Console.Write("{0}X^{1} + ", polynomial[i], i);
            }
        }
        Console.WriteLine("{0}", polynomial[0]);
    }

    static void Main()
    {
        // In this task we need to write only the methods, but if you want to test with different polynomials,
        // just change the one I have written below
        decimal[] polynomial1 = { 3, 0, -68, 8, 9 };
        decimal[] polynomial2 = { 1, 52, 61, 8 };
        PrintPolynomial(polynomial1);
        PrintPolynomial(polynomial2);
        Console.Write("The sum = ");
        PrintPolynomial(SumPolynomials(polynomial1, polynomial2));
    }
}

