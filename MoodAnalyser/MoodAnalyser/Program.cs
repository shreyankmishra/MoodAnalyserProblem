using System;

namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            string mood = "I am in Sad Mood";
            MoodAnalyse moodAnalyser = new MoodAnalyse(mood);
            System.Console.WriteLine(moodAnalyser.AnalyseMood());
        }
    }
}
