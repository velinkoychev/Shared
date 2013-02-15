using System;

class StandartDeckOfCards
{
    static void Main()
    {
        string suit="";
        string rank ="";
        for (int i = 1; i < 5; i++)
        {
            for (int j = 1; j < 14; j++)
            {
                switch (i)
                {
                    case 1:
                        {
                            suit = "clubs";
                            break;
                        }
                    case 2:
                        {
                            suit = "diamonds";
                            break;
                        }
                    case 3:
                        {
                            suit = "hearts";
                            break;
                        }
                    case 4:
                        {
                            suit = "spades";
                            break;
                        }
                }
                switch (j)
                {
                    case 1:
                        {
                            rank = "Ace";
                            break;
                        }
                    case 2:
                        {
                            rank = "2";
                            break;
                        }
                    case 3:
                        {
                            rank = "3";
                            break;
                        }
                    case 4:
                        {
                            rank = "4";
                            break;
                        }
                    case 5:
                        {
                            rank = "5";
                            break;
                        }
                    case 6:
                        {
                            rank = "6";
                            break;
                        }
                    case 7:
                        {
                            rank = "7";
                            break;
                        }
                    case 8:
                        {
                            rank = "8";
                            break;
                        }
                    case 9:
                        {
                            rank = "9";
                            break;
                        }
                    case 10:
                        {
                            rank = "10";
                            break;
                        }
                    case 11:
                        {
                            rank = "Jack";
                            break;
                        }
                    case 12:
                        {
                            rank = "Queen";
                            break;
                        }
                    case 13:
                        {
                            rank = "King";
                            break;
                        }
                }
                Console.WriteLine(" {0} of {1};", rank, suit);
            }
        }
    }
}

