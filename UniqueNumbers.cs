using System.Collections.Generic;
using System.Linq;
using System;

namespace UniqueNumbers

{
    class UniqueNumbers
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>();
            while(true)
            {
                Console.WriteLine("Write a number or type quit to exit");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                var uniques = new List<int>();
                foreach(var number in numbers)
                {
                    if (!uniques.Contains(number))
                        uniques.Add(number);
                }

                Console.WriteLine("Unique numbers:");
                foreach(var number in uniques)
                {
                    Console.WriteLine(number);
                }
            }

            
        }


    }
}
