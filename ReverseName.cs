using System.Collections.Generic;
using System.Linq;
using System;

namespace ReversedNameInput

{
    class AskName
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Whats your name?");
            var input = Console.ReadLine();

            var reversedName = new string(input.Reverse().ToArray());
            Console.WriteLine(reversedName);
        }


    }
}
