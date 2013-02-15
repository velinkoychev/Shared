//Write a program that enters file name along with its full file path 
//(e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. 
// Find in MSDN how to use System.IO.File.ReadAllText(…). 
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;
using System.Security;

class ReadFileToConsole
{
    static void Main()
    {
        Console.Write("Enter the full path of the file you want to read: ");
        string fileLocation = Console.ReadLine();
        try
        {
            ReadFile(fileLocation);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("You have not entered a file path!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The file path you have entered is not correct! Path contains only white space or contains one or more invalid characters!");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The entered file path is too long! For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The file path contains a directory that cannot be found (for example, it is on an unmapped drive)!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file specified in {0} was not found.", fileLocation);
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }
        catch (UnauthorizedAccessException uoae)
        {
            Console.WriteLine(uoae.Message);
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("{0} is in an invalid format..", fileLocation);
        }
        catch (SecurityException)
        {
            Console.WriteLine("You don't have the required permission to access this file!");
        }
        catch
        {
            Console.WriteLine("Something unexpected just happened. But don't worry, just try again!");
        }
    }

    static void ReadFile(string filePath)
    {
        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine("The content of the file is: ");
        Console.WriteLine(fileContent);
    }
}