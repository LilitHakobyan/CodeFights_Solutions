using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land_of_Logic_52_60
{
    class Program
    {
        //52
       static string longestWord(string text)
       {
           string[] subStrings = text.Split(' ');
           string maxStr = string.Empty;
           int maxCount = 0;
           int count = 0;
           for (int i = 0; i < subStrings.Length; i++)
           {
               string word = subStrings[i];
               string currentWord = string.Empty;
                for (int j = 0; j < subStrings[i].Length; j++)
               {
                   if (char.IsLetter(word[j]))
                   {
                       count++;
                       currentWord += word[j];
                   }
                   else break;
               }
               if (count > maxCount)
               {
                   maxCount = count;
                   maxStr = currentWord;
               }
                count = 0;
            }
           return maxStr;
       }

        static void Main(string[] args)
        {
            string str = "To be or not to be";
            longestWord(str);
        }
    }
}
