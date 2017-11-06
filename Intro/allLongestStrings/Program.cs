using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allLongestStrings
{
    class Program
    {
        public static  string[] allLongestStrings(string[] inputArray)
        {
            List<string> newArrayList=new List<string>();
            int maxSize =inputArray[0].Length;
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length>maxSize)
                {
                    maxSize = inputArray[i].Length;
                }
            }
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length==maxSize)
                {
                    newArrayList.Add(inputArray[i]);
                }
            }
            string[] newArray = newArrayList.ToArray();
            return newArray;
        }


        static void Main(string[] args)
        {
            string[] arrayStrings = {"aba", "aa", "ad", "vcd", "aba"};
            string[] newStringsarray = allLongestStrings(arrayStrings);
            for (int i = 0; i < newStringsarray.Length; i++)
            {
                Console.Write(newStringsarray[i]+" , ");
            }
        }
    }
}
