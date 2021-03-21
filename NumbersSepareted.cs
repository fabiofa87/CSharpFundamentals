using System.Collections.Generic;
using System.Linq;
using System;

namespace UniqueNumbers

{
    class UniqueNumbers
    {
        public static void Main(string[] args)
        {
            string[] elements;
            while (true)
            {
                Console.WriteLine("Enter a list of numbers separeted by commas");
                var input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List!");
            }

            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallestNumbers = new List<int>();
            while(smallestNumbers.Count < 3)
            {
                //Assuming the first is the smallest
                var min = numbers[0];
                foreach(var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallestNumbers.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smalelst numbers are: ");
            foreach (var number in smallestNumbers)
                Console.WriteLine(number);
            
        }


    }
}
