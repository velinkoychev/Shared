//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Security;

class ExtractFromHTML
{
    static void Main()
    {
        string htmlLocation = @"..\..\test.html";
        string resultLocation = @"..\..\output.txt";
        StreamReader streamReader = new StreamReader(htmlLocation);
        StreamWriter streamWriter = new StreamWriter(resultLocation);
        string htmlTitle = "";
        string htmlText = "";
        using (streamReader)
        {
            string titlePattern = "<title>(.*?)</title>";
            string pattern = "(?<=>).*?(?=<)";
            StringBuilder htmlTextOutput = new StringBuilder();
            htmlText = streamReader.ReadToEnd();
            Match match = Regex.Match(htmlText, titlePattern);
            htmlTitle = match.Value.Substring(7,match.Value.Length-15);
            Console.WriteLine("The title of the html page: {0}",htmlTitle);
            Match matchText = Regex.Match(htmlText, pattern);
            while (matchText.Success)
            {
                htmlTextOutput.Append(matchText.Value);
                matchText = matchText.NextMatch();
            }

            Console.WriteLine(htmlTextOutput);
        }
        using (streamWriter)
        {
            streamWriter.WriteLine(htmlText);
        }
        try { }
        catch { }
    }
}
