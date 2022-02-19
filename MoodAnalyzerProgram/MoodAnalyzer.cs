using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProgram
{
    public class MoodAnalyzer
    {
        public string message;
        public string exceptionMsg = "Mood cannot ne Null";
        public MoodAnalyzer()
        { }
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            if (this.message.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            if (this.message.ToLower().Contains("happy"))
            {
                return "HAPPY";
            }
            else
            { 
                return "";
            }
        }
    }
}
