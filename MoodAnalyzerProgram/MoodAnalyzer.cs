using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProgram
{
    public class MoodAnalyzer
    {
        /// <summary>
        /// analyze mood to find status
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
       public string AnalyzeMood(string message)
        {
            if (message.Contains("Happy"))
                return "Happy";
            else
                return "Sad";
        }
    }
}
