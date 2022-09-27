using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProgram
{
    public class MoodAnalyser
    {
        public string Analyse(string message)
        {
            if (message.Contains("Sad"))
                return("SAD");
            else
                return("HAPPY");
        }
    }
}
