using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProgram
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string msg)
        {
            this.message = msg;
        }

        public string Analyse()
        {
            if (message == string.Empty)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_MOOD, "Message is Empty");
            }
            try
            {
                if (message.Contains("Sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }catch(MoodAnalysisException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MOOD, "Message is Null");
            }
        }
    }
}
