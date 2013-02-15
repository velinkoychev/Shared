//Write a program that parses an URL address given in the format:
//[protocol]://[server]/[resource]
//and extracts from it the [protocol], [server] and [resource] elements.
//For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//[protocol] = "http"
//[server] = "www.devbg.org"
//[resource] = "/forum/index.php"

using System;
using System.Text;

class ParsesURLaddress
{
    static void Main()
    {
        string urlAddress = "http://www.devbg.org/forum/index.php";
        ParseURLaddress(urlAddress);
        Console.Write("Enter new URL address = ");
        urlAddress = Console.ReadLine();
        ParseURLaddress(urlAddress);
    }

    private static void ParseURLaddress(string urlAddress)
    {
        int protocolLastIndex = urlAddress.IndexOf(":");
        string protocol = urlAddress.Substring(0, protocolLastIndex);
        int serverLastIndex = urlAddress.IndexOf("/", protocolLastIndex + 3);
        string server = urlAddress.Substring(protocolLastIndex + 3, serverLastIndex - protocolLastIndex - 3);
        string resource = urlAddress.Substring(serverLastIndex);
        Console.WriteLine("[protocol] = " + protocol);
        Console.WriteLine("[server] = " + server);
        Console.WriteLine("[resource] = " + resource);
    }
}
