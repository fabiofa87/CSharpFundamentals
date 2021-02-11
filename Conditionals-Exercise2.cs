using System;

namespace Conditionals
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pick up a number");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick up another number");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            if(numberOne > numberTwo)
            {
                Console.WriteLine(numberOne);
            }
            else
            {
                Console.WriteLine(numberTwo);
            }

            
            
           
        }

        
    }
}
