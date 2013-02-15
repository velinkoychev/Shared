using System;

class UsersChoiceOfInput
{
    static void Main()
    {
        byte usersChoice;
        Console.Write("Please, enter 1 if you want to input int variable; Enter 2 if you want to input double variable and 3 if you want string variable:  " );
        bool correctInput = byte.TryParse(Console.ReadLine(), out usersChoice);
        if (!(correctInput && (usersChoice > 0) && (usersChoice < 4)))
        {
            Console.WriteLine("You have entered wrong number");
            Main();
        }
        switch (usersChoice)
        {
            case 1:
                Console.Write("Please, write the integer variable: ");
                int intVariable;
                correctInput = int.TryParse(Console.ReadLine(), out intVariable);
                if (correctInput)
                {
                    intVariable = intVariable + 1;
                    Console.WriteLine("The new variable is {0}", intVariable);
                }
                else
                {
                    Console.WriteLine("You have entered incorrect value! Sorry, try again!");
                    Main();
                }
                break;
            case 2:
                Console.Write("Please, write the double variable: ");
                double doubleVariable;
                correctInput = double.TryParse(Console.ReadLine(), out doubleVariable);
                if (correctInput)
                {
                    doubleVariable = doubleVariable + 1;
                    Console.WriteLine("The new variable is {0}", doubleVariable);
                }
                else
                {
                    Console.WriteLine("You have entered incorrect value! Sorry, try again!");
                    Main();
                }
                break;
            case 3:
                Console.WriteLine("Please, write the string variable: ");
                string stringVariable = Console.ReadLine() + "*";
                Console.WriteLine("Your new variable is {0}", stringVariable);
                break;
            default :
                Console.WriteLine("Sorry, there is an error");
                break;
        }
    }
}
