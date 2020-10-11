using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalysisException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE, NO_SUCH_FIELD,
            NO_SUCH_METHOD, NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }
        public readonly ExceptionType Type;
        public MoodAnalysisException(ExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }
    }
}
