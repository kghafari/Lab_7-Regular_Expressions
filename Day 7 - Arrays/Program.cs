using System;

namespace Day_7___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] intArray = new int[4];

            intArray[0] = 42;

            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);

            int arrSize = 25;
            char[] charArray;
            charArray = new char[arrSize];

            string[] animalArray = { "cat", "sharks", "elephant", "platypus", "kiwi" , "fox" };

            //for(int i=0; i < intArray.Length ; i++)

            ListOutStringArray(animalArray);
        }

        public static void ListOutStringArray(string[] array)
        {
            foreach (string word in array)
            {
                Console.WriteLine(word);
            }
            
        }
    }
}
