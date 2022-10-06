using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingSummarisingText
{
    class Program
    {
        public string SummarisingText(string sentence , int maxLength)
        {
            List<string> sammuryWords = new List<string>();
            if (sentence.Length < maxLength)
            {
                return sentence;
            }
            else
            {
                string[] words = sentence.Split(' ');
                int totalCharacters = 0;
                
                foreach (string word in words)
                {
                    sammuryWords.Add(word);
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > 20)
                    {
                        break;
                    }
                }
                string sammury = String.Join(" ", sammuryWords);
                string finalSammury =sammury.Remove(maxLength , (sammury.Length - maxLength));
                return  finalSammury + "...";
            }
            
        }
    }
}
