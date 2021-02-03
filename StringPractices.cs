using System;

namespace CSharpFundamentalsArrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            var firstName = "Fabio";
            var lastName = "Faria";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            Console.WriteLine(fullName);
            Console.WriteLine(myFullName);

            var names = new String[4] { "Fabio", "Nicole", "Luna", "Bilbo" };

            var formattedNames = string.Join(", ", names);

            var text = "Hi, my name is Fabio and i'm learning all about strings.\nYou should understand this text.\n And it should have few lines";
            var textVerb = @"Hi, my name is Fabio and i'm learning all about strings.
                             You should understand this text.
                             And it should have few lines.
                             But now we're using verbatum strings. Much better!";
            Console.WriteLine(textVerb);

        }
    }
}
