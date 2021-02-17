using System;

namespace Interations
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while(true){
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("@Echo: " + input);
                        break;
                }

                continue;

                
            }
        }
    }
}
