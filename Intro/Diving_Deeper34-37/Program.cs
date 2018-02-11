using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diving_Deeper34_37
{
    class Program
    {//34
        public static int[] extractEachKth(int[] inputArray, int k)
        {
            List<int> list = inputArray.ToList();
            k--;
            int index = k;
            while (index < list.Count)
            {
                list.RemoveAt(index);
                index += k;

            }
            inputArray = list.ToArray();
            return inputArray;
        }
        //35
        public static char firstDigit(string inputString)
        {
            for (int i = 0; i < inputString.Length; i++)
            {
                if (char.IsDigit(inputString[i]))
                    return inputString[i];
            }
            return inputString[0];
        }
        //36
        public static int differentSymbolsNaive(string s)
        {
            return s.Distinct().Count();
        }
        //37
        public static int arrayMaxConsecutiveSum(int[] inputArray, int k)
        {
            int sum = 0;
            int MaxSum = 0;
            for (int i = 0; i < inputArray.Length - k + 1; i++)
            {
                for (int j = i; j < i + k; j++)
                {
                    sum += inputArray[j];
                }
                MaxSum = Math.Max(sum, MaxSum);
                sum = 0;
            }
            return MaxSum;
        }

       

        static void Main(string[] args)
        {   //34
            int[] arr = { 2, 3, 5, 2 };
            //int [] res=extractEachKth(arr,3);
            //for (int i = 0; i < res.Length; i++)
            //{ 
            //    Console.Write($"{res[i]},");
            //}
            //35
            
        }

    }
}
