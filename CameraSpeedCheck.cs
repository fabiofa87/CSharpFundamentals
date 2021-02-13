using System;

namespace SpeedCamera
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Whats your speed limit?");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Whats your speed now?");
            int speedNow = Convert.ToInt32(Console.ReadLine());

            if (speedNow < speedLimit)
            {
                Console.WriteLine("Youre good.");
            }

            else
            {
                const int kmPerPoints = 5;
                var points = (speedNow - speedLimit) / kmPerPoints;
                if (kmPerPoints > 12)
                {
                    Console.WriteLine("Your license is suspended!");
                }
                else
                {
                    Console.WriteLine("Demerit Points: " + points);
                }
            }




        }
    }
}
