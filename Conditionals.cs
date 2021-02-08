using System;

namespace Conditionals
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool isGoldCustumer = true;

            //float price;

            //if (isGoldCustumer)
            //{
            //    price = 19.87f;
            //}
            //else
            //{
            //    price = 20.05f;
            //}

            //float price = (isGoldCustumer) ? 19.95f : 29.95f;

            //Console.WriteLine(price);

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Spring:
                    Console.WriteLine("We've got a promotion!");
                    break;
                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
                    
            }
        }

        
    }
}
