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
            try
            {
                if (this.message == null)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MOOD, "Mood should not be null");
                }
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_MOOD, "Mood should not be empty");
                }
                if (this.message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch(MoodAnalysisException ex)
            { return ex.Message; }
        }
    }
}
