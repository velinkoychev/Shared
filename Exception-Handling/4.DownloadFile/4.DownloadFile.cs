//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. 
//Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.


using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        using (WebClient webClient = new WebClient())
        {
            try
            {
                Console.WriteLine("Starting to download...");
                webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "../../Logo-BASD.jpg");
                Console.WriteLine("Downloaded!");
            }

            catch (WebException ex)
            {
                Console.Error.WriteLine("Sorry, there was an error!" + ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.Error.WriteLine("Sorry, you didn't enter anything!" + ex.Message);
            }
            catch (NotSupportedException ex )
            {
                Console.Error.WriteLine("Sorry, there was an error!" + ex.Message);
            }
        }
    }
}
