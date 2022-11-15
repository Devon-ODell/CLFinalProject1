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

        public void Go(string s)
        {

            string ans = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                int j = i;
                if (i >= s.Length)
                    break;
                while (i < s.Length && s[i] != ' ')
                    i++;
                if (ans.Length == 0)
                {
                    ans = ans + s.Substring(j + 1, i - j - 1)
                          + s[j] + "ay";
                }
                else
                {
                    ans = ans + " "
                          + s.Substring(j + 1, i - j - 1) + s[j]
                          + "ay";
                }
            }

        }

       
    }
    
}
