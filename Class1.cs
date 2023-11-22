using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myspace
{
    internal class ListOfWords
    {
        private List<string> words = new List<string>();
        public void addWord(string word)
        {
            for(int i = 0; i < word.Length; i++)
            {
                string word_ = "";
                for(int j = i; j < word.Length; j++)
                {
                    if (word[j] == ' ')
                    {
                        break;
                    }
                    word_ += word[j];
                    i++;
                }
                words.Add(word_);
            }
            
        }
        public void checkIfSameWords()
        {
            for(int i = 0; i<words.Count(); i++)
            {
               for(int ii = i+1; ii < words.Count(); ii++)
               {         
                    if (words[i] == words[ii])
                    {
                          words.RemoveAt(ii);
                        ii--;
                    }             
               }
            }
        }

        public override string? ToString()
        {
            string list = "Words list:\n";
            foreach(string s in words)
            {
                list += s + " ";
            }

            return list;
        }
    }
}
