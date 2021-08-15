using System;

namespace MoodAnalyzerProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to mood Analyzer Program");
            MoodAnalyzer mood = new MoodAnalyzer("I am Happy");
            string message = mood.AnalyzeMood();
            Console.WriteLine("Mood is : " + message);
        }
    }
}
