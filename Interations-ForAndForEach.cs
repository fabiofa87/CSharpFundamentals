using System;

namespace Interations
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for(var i = 1; i<=10; i++)
            {
                if(i % 2 == 0)
                {
                    //Console.WriteLine(i);
                }
            }

            //reversing the for loop
            for(var i = 10; i >= 1; i--)
            {
                if(i % 2 == 0)
                {
                    //Console.WriteLine(i);
                }
            }

            //foreach exercise

            //testing using loop to loop the index of a string
            //var name = "Fabio";
            //for(var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //foreach (var naming in name)
            //{
            //    Console.WriteLine(naming);
            //}

            var numbers = new int[] { 1, 2, 3, 4, 5 };
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
