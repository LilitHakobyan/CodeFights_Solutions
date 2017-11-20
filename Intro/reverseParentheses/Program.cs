using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseParentheses
{
    class Program
    {
        public static char[] Remove(char[] innerArray, int indexOfItem)
        {
            char[] tempArr = new char[innerArray.Length - 1];
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
        public static int FindIndex(string s, char simbol)
        {
            int k = -1;
            if (simbol == '(')
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == simbol)
                    {
                        k = i;
                    }
                }
                return k;
            }
            int c = -1;
            if (simbol == ')')
            {
                for (int i = s.Length - 1; i > -1; i--)
                {
                    if (s[i] == simbol)
                    {
                        c = i;
                    }
                }
                return c;
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
            while (startIndex != -1)
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
                StrCharArray = Remove(StrCharArray, endIndex - 1);
                s = string.Join("", StrCharArray);

                startIndex = FindIndex(s, '(');
                endIndex = FindIndex(s, ')');
            }


            return s;

            //while (s.Contains('('))
            //{
            //    int rightEnd = s.IndexOf(')');
            //    int leftEnd = s.Substring(0, rightEnd).LastIndexOf('(');
            //    string builder = s.Substring(0, leftEnd);
            //    for (int x = rightEnd - 1; x > leftEnd; x--)
            //    {
            //        builder += s[x];
            //    }
            //    builder += s.Substring(rightEnd + 1);
            //    s = builder;
            //}
            //return s;
        }
        static void Main(string[] args)
        {
            string s = "abc(cba)ab(bac)c";
            Console.WriteLine(reverseParentheses(s));

        }
    }
}
