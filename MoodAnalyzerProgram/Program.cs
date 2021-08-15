using System;

namespace MoodAnalyzerProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to mood Analyzer Program");
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            Console.WriteLine("Mood Status : " + moodAnalyzer.AnalyzeMood("Happy"));
        }
    }
}
