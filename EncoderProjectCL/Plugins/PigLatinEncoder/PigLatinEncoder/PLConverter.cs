using System;
using EncoderProjectCL;

namespace PigLatinEncoder
{
    public class PigLatinConverter : IPlugin
    {

        public string Name
        {
            get
            {
                return "PLConvert";
            }
        }

        public string Explanation
        {
            get
            {
                return "This plugin encodes text into Pig Latin";
            }
        }

        public string Go(string PLConvert)
        {

            string ans = Console.ReadLine();
            for (int i = 0; i < PLConvert.Length; i++)
            {
                int j = i;
                if (i >= PLConvert.Length)
                    break;
                while (i < PLConvert.Length && PLConvert[i] != ' ')
                    i++;
                if (ans.Length == 0)
                {
                    ans = ans + PLConvert.Substring(j + 1, i - j - 1)
                          + PLConvert[j] + "ay";
                }
                else
                {
                    ans = ans + " "
                          + PLConvert.Substring(j + 1, i - j - 1) + PLConvert[j]
                          + "ay";
                }
            }

            return ans;

        }

        void IPlugin.Go(string parameters)
        {
            throw new NotImplementedException();
        }
    }
    
}
