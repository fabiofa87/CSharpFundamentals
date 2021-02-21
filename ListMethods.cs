using System.Collections.Generic;

namespace ListMethods

{
    class MethodsList
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4};
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7});

            foreach(var n in numbers)
                System.Console.WriteLine(n);

            System.Console.WriteLine("Index of: " + numbers.IndexOf(1));

            System.Console.WriteLine("Last indexOf 1: " + numbers.LastIndexOf(1));


            System.Console.WriteLine("Count: " + numbers.Count);

            for (int i = 0; i < numbers.Count; i++)
            {
                
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            System.Console.WriteLine();

            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }

            numbers.Clear();
            System.Console.WriteLine(numbers.Count);
        }

        
    }
}
