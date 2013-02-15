using System;
using System.Text;

class ASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        for (short counter = 0; counter <= 255; counter++)
        {
            Console.WriteLine("ASCII " + Convert.ToString(counter) + ": " + (char)counter + " ");
        }
    }
}
