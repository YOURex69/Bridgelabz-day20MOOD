using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
       
        
        
        
        public string analyseMood(string str1)
        {
            string key = "Sad";
            if (str1.Contains(key))
            {
                
                return"SAD" ;
                
            }
            else
            {
                return "HAPPY";
            }
        }
       
    }
}
