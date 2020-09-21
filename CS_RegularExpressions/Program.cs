using System;
using System.Text.RegularExpressions;

namespace CS_RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
           string text = @"This is a email address anhduynguyen020595@gmail.com and nguyenanhduy020595@gmail.com";
           string pattern = @"(([^\s.]+)@((.[^\s]+)(\..[^\s]+)))";

           Regex regex =  new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

           MatchCollection matches = regex.Matches(text);

           System.Console.WriteLine("Found {0} email", matches.Count);

           foreach (Match match in matches)
           {
               GroupCollection groups = match.Groups;
               System.Console.WriteLine("{0}", groups[0].Value);
           }
        }
    }
}
