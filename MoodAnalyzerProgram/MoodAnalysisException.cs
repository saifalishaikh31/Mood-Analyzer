﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProgram
{
    public class MoodAnalysisException : Exception
    {
        public enum ExceptionType
        {
            NULL_MOOD,
            EMPTY_MOOD
        }
        public ExceptionType exceptionType;
        public MoodAnalysisException(ExceptionType type,string message):base(message)
        {
            this.exceptionType = type;
        }
    }
}
