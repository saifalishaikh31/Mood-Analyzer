using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzerProgram
{
    public class MoodAnalyseFactory
    {
        public string message;
        public MoodAnalyseFactory(string message)
        {
            this.message = message;
        }
        public static object CreateMoodAnalyse(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }

                catch (ArgumentNullException)
                {

                    return new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "Class not found");
                }
            }
            else
            {
                return new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CONSTRUCTOR, "No such method");
            }

        }        
    }
}
