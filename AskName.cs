using System.Collections.Generic;
using System;

namespace AskNameExercise

{
    class AskName
    {
        public static void Main(string[] args)
        {
            var names = new List<string> { };

            while (true)
            {
                System.Console.WriteLine("Give me a name or nothing");
                var input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input))
                {
                    names.Add(input);
                    continue;
                }
                else
                    break;
            }
            foreach (var name in names)
            {

                Console.WriteLine(name);
                    Console.WriteLine();

            }

            Console.WriteLine("You gave me: " + names.Count + " names");

        }

        
    }
}
