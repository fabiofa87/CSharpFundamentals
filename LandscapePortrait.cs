using System;

namespace Conditionals
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's see if your photo is a Landscape or Portrait.");
            Console.WriteLine("Height of the photo:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("width of the photo:");
            int width = Convert.ToInt32(Console.ReadLine());

            if(height > width)
            {
                Console.WriteLine("Your photo is a landscape!");
            }
            else
            {
                Console.WriteLine("Your photo is a portrait!");
            }
            
        }

        
    }
}
