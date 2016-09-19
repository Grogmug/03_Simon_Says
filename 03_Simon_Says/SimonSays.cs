using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Simon_Says
{
    internal class Simon
    {
        public string Echo(string s)
        {
            return s.ToLower();
            
        }
        public string Shout(string s)
        {
          return s.ToUpper();
        }

        public string Repeat(string hello, int repeats = 2)
        {
            string returnString = "";
            for (int i = 0; i < repeats; i++ )
            {
                if (i != 0)
                {
                    returnString += " ";
                }
                returnString += hello;
            }
            return returnString;
        }
        public string StartOfWord(string s, int t)
        {
            return s.Substring(0,t);
        }

        public string FirstWord(string h)
        {
            string firstWord = h.Split(' ').First();
            return firstWord;
        }

        public string Titleize(string text)
        {
            string[] gitGud = text.Split(' ');
            string completeSen = "";
            for (int i = 0; i < gitGud.Length; i++)
            {
                if (gitGud[i] != "and" && gitGud[i] != "the" && gitGud[i] != "over")
                {
                    completeSen += gitGud[i].Substring(0, 1).ToUpper() + gitGud[i].Substring(1) + " ";
                }
                else
                {
                    completeSen += gitGud[i] + " ";
                }
            }
            completeSen = completeSen.Substring(0, 1).ToUpper() + completeSen.Substring(1);
            return completeSen.Trim();
        }
    }
}
