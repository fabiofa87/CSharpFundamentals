using System;

namespace GuessNumberExercise

{
    class GuessNumber
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            var rdNumber = random.Next(1, 10);

            for(var i = 0; i < 4; i++)
            {
                Console.WriteLine("Pick the correct number: ");
                if (Convert.ToInt32(Console.ReadLine()) == rdNumber)
                {
                    Console.WriteLine("You win!");
                    break;
                }
                else
                {
                    continue;
                }
            }

            //Console.WriteLine(rdNumber);
        }

        
    }
}
