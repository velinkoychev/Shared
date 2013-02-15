//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

using System;
class SurfaceOfTriangle
{
    static int counterOfVisits = 0;

    static double ReadDecimalValue(string value)
    {
        bool correctInput = false;
        double valueInput = 0;
        while (!correctInput)
        {
            Console.Write("Please, enter {0} = ", value);
            correctInput = double.TryParse(Console.ReadLine(), out valueInput);
            if (valueInput < 0)
            {
                Console.WriteLine("Sorry, you can't enter negative {0}", value);
                correctInput = false;
            }
        }
        return valueInput;
    }
    static double SideAndAltitude(double sideA, double altitude)
    {
        double surface = (sideA * altitude) / 2;
        return surface;
    }

    static double ThreeSides(double sideA, double sideB, double sideC)
    {
        double perimeter = (sideA  + sideB + sideC) / 2;
        double surface = Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));

        return surface;
    }
    // S = (a * b * sinx) / 2

    static double TwoSidesAndAngleInDegrees(double sideA, double sideB, double angle)
    {
        return (sideA * sideB * Math.Sin(Math.PI * angle / 180)) / 2;
    }

    static double TwoSidesAndAngleInRadians(double sideA, double sideB, double angle)
    {
        return (sideA * sideB * Math.Sin(angle)) / 2;
    }

    static void Main()
    {
        int option = 0;
        if (counterOfVisits == 0)
        {
            Console.WriteLine("Welcome, stranger!  Choose what you have in order to calculate the surface of a triangle:");
        }
        counterOfVisits++;
        Console.WriteLine();
        Console.WriteLine("+---------------------------------------------------+");
        Console.WriteLine(" 1. Side and an altitude to it                      |");
        Console.WriteLine(" 2. Three sides                                     |");
        Console.WriteLine(" 3. Two sides and an angle (in degrees) between them|");
        Console.WriteLine(" 4. Two sides and an angle (in radians) between them|");
        Console.WriteLine(" 5. Exit                                            |");
        Console.WriteLine("+---------------------------------------------------+");
        bool correctInput = false;
        while (!correctInput)
        {
            Console.Write("Choose a task number: ");
            correctInput = int.TryParse(Console.ReadLine(), out option);
            if ((option > 5) || (option < 1))
            {
                correctInput = false;
            }
        }
        correctInput = false;
        switch (option)
        {
            case 1:
                {
                    double sideA = ReadDecimalValue("side");
                    double altitude = ReadDecimalValue("altitude");
                    Console.WriteLine("The surface = {0}",SideAndAltitude(sideA, altitude));
                    Main();
                    break;
                }
            case 2:
                {
                    double sideA = ReadDecimalValue("1st side");
                    double sideB = ReadDecimalValue("2nd side");
                    double sideC = ReadDecimalValue("3th side");
                    Console.WriteLine("The surface = {0}", ThreeSides(sideA, sideB, sideC));
                    Main();
                    break;
                }
            case 3:
                {
                    double sideA = ReadDecimalValue("1st side");
                    double sideB = ReadDecimalValue("2nd side");
                    double angle = ReadDecimalValue("angle");
                    Console.WriteLine("The surface = {0}", TwoSidesAndAngleInDegrees(sideA, sideB, angle));
                    Main();
                    break;
                }
            case 4:
                {
                    double sideA = ReadDecimalValue("1st side");
                    double sideB = ReadDecimalValue("2nd side");
                    double angle = ReadDecimalValue("angle");
                    Console.WriteLine("The surface = {0}", TwoSidesAndAngleInRadians(sideA, sideB, angle));
                    Main();
                    break;
                }
            case 5:
                Console.WriteLine("Good-bey, stranger!");
                break;
        }
    }
}
