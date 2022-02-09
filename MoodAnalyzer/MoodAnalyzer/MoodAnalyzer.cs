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
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        //uc-2 handling exceptions
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
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                return "happy";
            }

        }
    }
    
}
