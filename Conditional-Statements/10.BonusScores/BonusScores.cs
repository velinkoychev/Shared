using System;

class BonusScores
{
    static void Main()
    {
        int userChoice;
        Console.WriteLine("Please, write a number in the range [1..9]");
        bool correct = int.TryParse(Console.ReadLine(), out userChoice);
        if ((!correct) || (userChoice > 9) || (userChoice < 1))
        {
            Console.WriteLine("Sorry, you have entered a wrong number. Please, try again");
            Main();
        }
        switch (userChoice)
        {
            case 1 :
            case 2 :
            case 3 :
                userChoice = userChoice * 10;
                break;
            case 4:
            case 5:
            case 6:
                userChoice = userChoice * 100;
                break;
            case 7 :
            case 8 :
            case 9 :
                userChoice = userChoice * 1000;
                break;
            default :
                Console.WriteLine("Sorry, there is an error");
                break;
        }
        Console.WriteLine("The new value = {0}", userChoice);
    }
}

