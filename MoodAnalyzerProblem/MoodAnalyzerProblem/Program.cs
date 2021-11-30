using System;

namespace MoodAnalyzerProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyzer obj1 = new MoodAnalyzer();
            Console.WriteLine("Enter the sentence: ");
            string str1 = Console.ReadLine();

            Console.WriteLine(obj1.analyseMood(str1));

        }
    }
}
