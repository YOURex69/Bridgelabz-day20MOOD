using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserUC1refactor
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
                else
                {
                    return "HAPPY";
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return e.Message;
            }

        }



    }
}
