using System;
class Slices3d
{
    static void Main()
    {
        string readSizes = Console.ReadLine();
        string[] sizes = readSizes.Split(' ');
        int count = 0;
        int width = int.Parse(sizes[0]);
        int height = int.Parse(sizes[1]);
        int debth = int.Parse(sizes[2]);

        int[, ,] cube = new int[width, height, debth];
        long totalSum = 0;
        for (int h = 0; h < height; h++)
        {
            string line = Console.ReadLine();
            string[] tokens = line.Split('|');
            for (int d = 0; d < debth; d++)
            {
                string[] numbers = tokens[d].Split(
                    new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);
                for (int w = 0; w < width; w++)
                {
                    int value = int.Parse(numbers[w]);
                    cube[w, h, d] = value;
                    totalSum = totalSum + value;
                }
            }
        }
        long sum = 0;
        for (int w = 0; w < width-1; w++)
        {
            for (int h = 0; h < height; h++)
            {
                for (int d = 0; d < debth; d++)
                {
                    sum = sum + cube[w, h, d];
                }
            }
            if (sum * 2 == totalSum)
            {
                count++;
            }
        } 
        sum = 0;
        for (int d = 0; d < debth-1; d++)
        {
            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    sum = sum + cube[w, h, d];
                }
            }
            if (sum * 2 == totalSum)
            {
                count++;
            }
        }
        sum = 0;
        for (int h = 0; h < height-1; h++)
        {
            for (int w = 0; w < width; w++)
            {
                for (int d = 0; d < debth; d++)
                {
                    sum = sum + cube[w, h, d];
                }
            }
            if (sum * 2 == totalSum)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}
