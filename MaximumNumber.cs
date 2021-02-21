using System;

namespace MaximumNumber

{
    class MaxNumber
    {
        public static void Main(string[] args)
        {
            var numbers = new [] { 3, 5, 6, 8, 19 };

            // Length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 5);
            Console.WriteLine("Index of : " + index);

            // Clear()
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect on Clear()");
            foreach(var n in numbers)
                Console.WriteLine(n);

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect on Copy(): ");

            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            // Sort()
            Array.Sort(numbers);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Reverse()

            Array.Reverse(numbers);
            foreach (var n in numbers)
                Console.WriteLine(n);
            {

            }
        }

        
    }
}
