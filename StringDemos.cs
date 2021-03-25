using System.Collections.Generic;
using System.Linq;
using System;

namespace NumbersSepareted

{
    class NumbersSepareted
    {
        public static void Main(string[] args)
        {
            var fullName = "Fabio Faria ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim() );// Take out whitespaces like the eg
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            Console.WriteLine("Trim: '{0}'", fullName.Trim());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            //easier way to do using split method

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            // same result as above but simplier way :)

            Console.WriteLine(fullName.Replace("Fabio", "Nicole"));

            if(String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid!");

            float price = 29.65f;

            Console.WriteLine(price.ToString("C"));
        }


    }
}
