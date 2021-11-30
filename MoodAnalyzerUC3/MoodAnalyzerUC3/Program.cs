using System;

namespace MoodAnalyzerUC3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter line :");
            string line = Console.ReadLine();
            MoodAnalyzer obj1 = new MoodAnalyzer(line);
            Console.WriteLine(obj1.analyseMood());


        }
    }
}
