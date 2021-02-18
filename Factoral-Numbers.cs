using System;

namespace DivisibleLoop

{
    class FactoralNumbers
    {
        public static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Pick a Number: ");
            Int32.TryParse(Console.ReadLine(), out number);
            Console.WriteLine("Factoral number of " + number + " is : " + Factorial(number));

            
        }

        private static int Factorial(int number)
        {
            if (number == 0)
                return 1;
            else
                return number * Factorial(number - 1);
        }
    }
}
