using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerUC3
{
   public class MoodAnalyzer
    {
        public string str1 = "";
        public MoodAnalyzer(string s)
        {
            this.str1 = s;
        }
        public string analyseMood()
        {
            try
            {
                string key = "Sad";
                if (str1.Contains(key))
                {
                    return "SAD";
                }
                else if(str1.Contains("EMPTY"))
                {

                    throw new MoodAnalysisException("EMPTY");
                }
                else if(str1.Contains("NULL"))
                {
                    throw new MoodAnalysisException("NULL");
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (MoodAnalysisException e)
            {
                Console.WriteLine(e.Message);
                return e.Message;
            }

        }

    }

    [Serializable]
    class MoodAnalysisException : Exception
    {
        public MoodAnalysisException() { }

        public MoodAnalysisException(string name)
            : base(String.Format("Invalid Mood: {0}", name))
        {

        }
    }






}
