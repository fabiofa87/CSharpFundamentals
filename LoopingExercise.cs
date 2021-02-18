using System;

namespace DivisibleLoop

{
    class LoopExercise
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                int sum = 0;
                while (true)
                {
                    Console.WriteLine("Give me a number: ");
                    int n;
                    if (int.TryParse(Console.ReadLine(), out n))
                    {
                        if (n == 0)
                            break;
                        sum += n;
                    }
                }
                Console.WriteLine("The sum is: " +  sum);
                break;
                
            }
        }
    }
}
