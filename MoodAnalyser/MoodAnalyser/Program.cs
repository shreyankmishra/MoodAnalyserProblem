using System;

namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string mood = Console.ReadLine();
                MoodAnalyse moodAnalyser = new MoodAnalyse(mood);
                string res = moodAnalyser.AnalyseMood();
                Console.WriteLine(res);
            }
            catch (MoodAnalysisException m)
            {
                Console.WriteLine(m.Message);
            }
        }
    }
}
