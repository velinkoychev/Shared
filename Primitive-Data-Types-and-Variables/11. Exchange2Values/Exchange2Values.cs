using System;
class Exchange2Values
{
    static void Main()
    {
        int variable1 = 5;
        int variable2 = 10;
        int variableTemp;

        Console.WriteLine("Variable 1 = {0}, Variable 2 = {1}", variable1, variable2);
        variableTemp = variable1;
        variable1 = variable2;
        variable2 = variableTemp;
        Console.WriteLine("Variable 1 = {0}, Variable 2 = {1}", variable1, variable2);
    }
}
