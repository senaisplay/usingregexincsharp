using System;
using System.Text.RegularExpressions;

namespace UsingRegexInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"^[\w]{1,}[@]{1}[\w]{1,}(?>[.{1}][\w]+)+$";
            var email = "splay@senai.br";
            var invalid = "SENAI SPlay";
            //
            var matches = Regex.Match(email, regex);
            if(matches.Success)
            {
                Console.WriteLine("Valid e-mail");
            }
            else
            {
                Console.WriteLine("Invalid e-mail");
            }
        }
    }
}
