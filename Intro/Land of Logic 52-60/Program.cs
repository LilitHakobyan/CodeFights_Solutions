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
        //53
        static bool validTime(string time)
        {
            int firstPart = Convert.ToInt32(String.Concat(time[0], time[1]));
            int lastPart = Convert.ToInt32(String.Concat(time[3], time[4]));
           
            if (firstPart < 0 || firstPart > 23)
                return false;
            if (lastPart < 0 || lastPart > 59)
                return false;
         

            return true;
        }
        //54
       static int sumUpNumbers(string inputString)
       {
           int sum = 0;
           string app = string.Empty;
           for (int i = 0; i < inputString.Length; i++)
           {
               if (Char.IsDigit(inputString[i]))
               {
                   while (Char.IsDigit(inputString[i]))
                   {
                       app += inputString[i];
                       i++;
                        if(i>inputString.Length-1)
                            break;
                   }
                   sum += Convert.ToInt32(app);
                   app = string.Empty;
               }
               
           }
           return sum;
       }
        //55
       static int differentSquares(int[][] matrix)
        {
            List<int> list = new List<int>();
            for (var i = 0; i < matrix.Length - 1; i++)
            {
                for (var j = 0; j < matrix[0].Length - 1; j++)
                {
                    list.Add(matrix[i][j] + matrix[i + 1][j + 1] * 10 +
                             matrix[i + 1][j] * 100 + matrix[i][j + 1] * 1000);
                }
            }
            return list.Distinct().Count();
        }
        //56
       static int digitsProduct(int product)
        {
            if (product == 0) return 10;
            if (product == 1) return 1;
            string digits = "";
            for (int divisor = 9; divisor >1; divisor--)
            {
                while (product % divisor == 0)
                {
                    product /= divisor;
                    digits = divisor.ToString() + digits;
                }
            }

            if (product > 1) return -1;

            return int.Parse(digits);
        }
        static void Main(string[] args)
        {
            //string str = "To be or not to be";
            //longestWord(str);
            string inputString = "123";
            sumUpNumbers(inputString);
        }
    }
}
