﻿//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 

using System;
using System.Text.RegularExpressions;
class ReplaceTags
{
    static void Main()
    {
        string htmlFragment = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        string regex = "<a\\s*href\\s*=\"(.*?)\"\\s*>(.*?)</a>";
        string newHtmlFragment = Regex.Replace(htmlFragment, regex, "[URL=$1]$2[/URL]");
        Console.WriteLine(newHtmlFragment);
    }
}

