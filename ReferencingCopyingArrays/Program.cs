using System;

namespace ReferencingCopyingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tvShowArray = { "Friends", "The Witcher", "Curb Your Enthusiasm", "The Office", "Community", "Orange is the New Black", "Schitts Creek" };


            //createes a refernce to tvShowArray called tvArray
            string[] tvArray = tvShowArray;
            // Any changes to tvArray will also affect the tvShowArray, and vice versa.

            string[] copyToArray = new string[tvShowArray.Length];
            tvShowArray.CopyTo(copyToArray, 0);

            Array.Sort(tvArray);

            Console.WriteLine("This is our tvArray - the reference to tvShowArray:");

            foreach (string show in tvArray)
            {
                Console.WriteLine(show);
            }

            Console.WriteLine("\nThis is our copyTVArray - a copy of our tvShowArray");

            foreach (string show in copyToArray)
            {
                Console.WriteLine(show);
            }

        }
    }
}
