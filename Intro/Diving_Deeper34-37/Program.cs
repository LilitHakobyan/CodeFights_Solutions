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

        //39
        public static int knapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {
            if (weight2 > maxW && weight1 > maxW)
                return 0;
            if (weight1 == maxW && weight2 > maxW)
                return value1;
            if (weight2 == maxW && weight1 > maxW)
                return value2;
            return weight1 + weight2 <= maxW ? value1 + value2 : Math.Max(value1, value2);
        }
        //40
        public static string longestDigitsPrefix(string inputString)
        {
            string outputSt = String.Empty;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (char.IsNumber(inputString[i]))
                    outputSt += inputString[i];
                else
                {
                    break;
                }
            }
            return outputSt;
        }
        //41
        public static int digitDegree(int n)
        {
            int count = 0;
            int sum = 0;
            if (n < 10)
                return 0;
            do
            {
                sum = 0;
                while (n != 0)
                {
                    sum += n % 10;
                    n = n / 10;
                }
                n = sum;
                count++;
            }
            while (sum >= 10);
            return count;
        }

        //42
        bool bishopAndPawn(string bishop, string pawn)
        {
            return Math.Abs(bishop[0] - pawn[0]) == Math.Abs(bishop[1] - pawn[1]);
        }
        //43
        public static bool isBeautifulString(string inputString)
        {
            List<char> list = inputString.ToList();
            list.Sort();
            var diList = list.Distinct().ToArray();
            int[] arr = new int[diList.Length];
            int count = 0;
            for (int j = 0; j < diList.Length; j++)
            {
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (diList[j] == inputString[i])
                        count++;
                }
                arr[j] = count;
                count = 0;
            }


            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {   //34
            //int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //int [] res=extractEachKth(arr,3);
            //for (int i = 0; i < res.Length; i++)
            //{ 
            //    Console.Write($"{res[i]},");
            //}
            //35
            string inp = "bbc";
            isBeautifulString(inp);
        }

    }
}
