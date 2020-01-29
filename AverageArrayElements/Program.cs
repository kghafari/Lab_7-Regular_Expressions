using System;

namespace AverageArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] grades = { 20, 85, 66.6, 98.7, 100, 1, 65.1, 2, };

            double average = GetGradeAverage(grades);

            Console.WriteLine($"Your average is: {average}");

        }

        // create a method that takes in a double[]. 
        // Method should return the average of all elements in the array
        public static double GetGradeAverage(double[] grades)
        {
            double sum = 0;
            foreach(double grade in grades)
            {
                sum += grade;
            }
            return (sum / grades.Length);
        }

    }
}
