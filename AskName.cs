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

            if(names.Count > 2)
            {
                Console.WriteLine("{0}, {1}, and {2} others like your post!", names[0], names[1], names.Count - 2);
            }
            else if(names.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post.", names[0], names[1]);
            }
            else if(names.Count == 1)
            {
                Console.WriteLine("{0} likes your post!", names[0]);
            }
            else
            {
                Console.WriteLine();
            }


            Console.WriteLine("You gave me: " + names.Count + " names");

        }


    }
}
