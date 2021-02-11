using System;

namespace Conditionals
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pick a number between 1 and 10.");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number <= 10 && number >= 1)
            {
                Console.WriteLine("Your number is valid");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
           
        }

        
    }
}
