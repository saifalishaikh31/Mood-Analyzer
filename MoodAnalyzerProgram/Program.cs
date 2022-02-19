using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Anayzer Program");
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am in Happy Sad");
            Console.WriteLine("Mood is: " + moodAnalyzer.AnalyseMood());
            Console.ReadLine();
        }
    }
}
