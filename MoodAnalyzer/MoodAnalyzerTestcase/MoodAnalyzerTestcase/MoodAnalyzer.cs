using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerTestcase
{
    public class MoodAnalyzer
    {
        public string message;  //instance variable      


        public MoodAnalyzer(string message) //parameterized constructor 
        {
            this.message = message;

        }
        public string Analyzer()  //Analyzer method find mood
        {
            try
            {
                if (this.message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                return "happy";
            }
        }
    }
}
