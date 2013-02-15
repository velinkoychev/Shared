using System;
using System.Collections.Generic;
using System.Threading;

struct DwarfAndRocks
{
    public int x;
    public int y;
    public string body;
    public ConsoleColor color;
}
class FallingRocks
{
    static void PrintOnPossition(int x, int y, string c, ConsoleColor color = ConsoleColor.DarkRed)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }

    static void Main()
    {
        int playfieldWidth = Console.WindowWidth;
        int numberOfLives = 5;
        long score = 0;
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
        DwarfAndRocks smallDwarf = new DwarfAndRocks();
        smallDwarf.x = Console.WindowWidth / 2 - 1;
        smallDwarf.y = Console.WindowHeight - 1;
        smallDwarf.color = ConsoleColor.White;
        smallDwarf.body = "(0)";
        Random randomGenerator = new Random();
        List<DwarfAndRocks> rocks = new List<DwarfAndRocks>();
        ConsoleColor[] color = { ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkRed, ConsoleColor.DarkYellow };
        string[] bodyType = { "@", "*", "&", "+", "%", "$", "#", "!", ".", ";", "-" };
        while (true)
        {
            for (int i = 0; i < randomGenerator.Next(0, 4); i++)
            {
                DwarfAndRocks newRock = new DwarfAndRocks();
                newRock.x = randomGenerator.Next(0, playfieldWidth);
                newRock.color = color[randomGenerator.Next(0, 6)];
                newRock.body = bodyType[randomGenerator.Next(0, 11)];
                for (int j = 0; j < randomGenerator.Next(1, 4); j++)
                {
                    if (newRock.x <= (playfieldWidth - 4))
                    {
                        newRock.body = newRock.body + newRock.body;
                    }
                }
                rocks.Add(newRock);
            }

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (smallDwarf.x - 1 >= 0)
                    {
                        smallDwarf.x--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (smallDwarf.x + 1 <= playfieldWidth)
                    {
                        smallDwarf.x++;
                    }
                }
            }
            Console.Clear();
            List<DwarfAndRocks> newRocks = new List<DwarfAndRocks>();
            for (int i = 0; i < rocks.Count; i++)
            {
                DwarfAndRocks oldRock = rocks[i];
                DwarfAndRocks newRock = new DwarfAndRocks();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.body = oldRock.body;
                newRock.color = oldRock.color;
                if (newRock.y == smallDwarf.y && (smallDwarf.x <= (newRock.x + newRock.body.Length-1)) && (newRock.x <= (smallDwarf.x + smallDwarf.body.Length-1)))
                {
                    numberOfLives--;
                    if (numberOfLives == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Game over");
                        Console.WriteLine("Your score=" + score);
                        return;
                    }

                }
                if (newRock.y < Console.WindowHeight)
                {
                    newRocks.Add(newRock);
                }
                score++;
            }
            rocks = newRocks;
            foreach (DwarfAndRocks rock in rocks)
            {
                PrintOnPossition(rock.x, rock.y, rock.body, rock.color);
            }
            PrintOnPossition(0, 0, "Score= " + Convert.ToString(score) + "    ", ConsoleColor.White);
            PrintOnPossition(40, 0, "Lives= " + Convert.ToString(numberOfLives), ConsoleColor.White);
            PrintOnPossition(smallDwarf.x, smallDwarf.y, smallDwarf.body, smallDwarf.color);
            Thread.Sleep(150);

        }
        
    }

}

