using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseParentheses
{
    class Program
    {
        public static char[] Remove(char [] innerArray, int indexOfItem)
        {
            char [] tempArr = new char[innerArray.Length - 1];
            try
            {
                for (int i = 0; i < indexOfItem; i++)
                {
                    tempArr[i] = innerArray[i];
                }
                for (int i = indexOfItem; i < tempArr.Length; i++)
                {
                    tempArr[i] = innerArray[i + 1];

                }
             
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Remov Item not found ");
            }
            return tempArr;
        }
        public static  int  FindIndex(string s,char simbol)
        {
            if (simbol=='(')
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == simbol)
                    {
                        return i;
                    }
                }
            }
            if (simbol == ')')
            {
                for (int i = s.Length-1; i >-1; i--)
                {
                    if (s[i] == simbol)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static string reverseParentheses(string s)
        {
            int startIndex = 0;
            int endIndex = 0;
            startIndex = FindIndex(s, '(');
            endIndex = FindIndex(s, ')');
            while (startIndex!=-1)
            {
                int length = endIndex - startIndex - 1;
                string subSt = s.Substring(startIndex + 1, length);
                string reversString = Reverse(subSt);
                char[] StrCharArray = s.ToCharArray();
                int j = 0;
                for (int i = startIndex + 1; i < endIndex; i++)
                {
                    StrCharArray[i] = reversString[j];
                    j++;
                }
                StrCharArray = Remove(StrCharArray, startIndex);
                StrCharArray = Remove(StrCharArray, endIndex-1);
                s = string.Join("", StrCharArray);

                startIndex = FindIndex(s, '(');
                endIndex = FindIndex(s, ')');
            }
                
                     
           return s;


        }
        static void Main(string[] args)
        {
            string s = " a(bcdefghijkl(mno)p)q";
            Console.WriteLine(reverseParentheses(s));

        }
    }
}
