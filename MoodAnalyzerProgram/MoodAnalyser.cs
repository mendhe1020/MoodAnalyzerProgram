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
            try
            {
                if (message.Contains("Sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }catch(NullReferenceException ex)
            {
                return "HAPPY";
            }
        }
    }
}
