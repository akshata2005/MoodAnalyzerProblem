using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyzer
    {
        public string message; //instance variable
        public MoodAnalyzer (string message)
        {
            this.message = message;
        }
    }
    public string Analyzer()//
    {
        if(this.message.ToLower().Contains("happy"))
        {
            return "happy";
        }
    }
}
