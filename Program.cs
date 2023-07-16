using System;

namespace AverageWordLengthCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();

            double aLength = AverageWordLength(inputString);
            double roundedAverageLength = Math.Round(aLength, 3);

            Console.WriteLine($"The average word length is: {roundedAverageLength}");
        }

        static double AverageWordLength(string inputString)
        {
            string[] words = inputString.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int totalLength = 0;
            foreach (string word in words)
            {
                totalLength += word.Length;
            }

            double averageLength = (double)totalLength / words.Length;
            return averageLength;
        }
    }
}