using System.Collections.Generic;
using System.Linq;
using System;

namespace ListNumbers

{
    class NumberListed
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>();

            while(numbers.Count < 5)
            {
                Console.WriteLine("Enter a number");
                var number = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've previouly entered " + number);
                    continue;
                }
                numbers.Add(number);
            }

            numbers.Sort();

            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
        }


    }
}
