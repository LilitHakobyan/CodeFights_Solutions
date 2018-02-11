using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_48
{
    class Program
    {
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
        //44
        static string findEmailDomain(string address)
        {
            var splits = address.Split('@');
            return splits.Last();
        }
        //45
        static string buildPalindrome(string str)
        {
            string reverseStr = new string(str.ToCharArray().Reverse().ToArray());
            int len = 0;
            for (len = reverseStr.Length; len > 0 && str.LastIndexOf(reverseStr.Substring(0, len)) != str.Length - len; len--) ;
            return str + reverseStr.Substring(len);

        }
        //46
        static int electionsWinners(int[] votes, int k)
        {
            int count = 0;
            int currentVotes = votes[0];
            bool flag = true;
            for (int i = 0; i < votes.Length; i++)
            {
                currentVotes = votes[i] + k;
                flag = true;
                for (int j = 0; j < votes.Length; j++)
                {
                    if (votes[j] >= currentVotes && i != j)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    count++;
                }
            }
            return count;
        }
        //47
        static bool isMAC48Address(string str)
        {
            if (str.Length != 17)
                return false;
            if (!(str[2] == '-' && str[5] == '-' && str[8] == '-' && str[11] == '-' && str[14] == '-'))
                return false;
            string num = "0123456789";
            string let = "ABCDEF";
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 2 || i == 5 || i == 8 || i == 11 || i == 14)
                    continue;
                if (!(num.Contains(str[i]) || let.Contains(str[i])))
                {
                    return false;
                }

            }
            return true;
        }

        //49
        static string lineEncoding(string s)
        {

            int count = 1;
            string concatStr = String.Empty;
            List<char> let = new List<char>() { s.First() };
            List<int> num = new List<int>();
            for (int i = 1; i < s.Length; i++)
            {
                if (let.Last() != s[i])
                {
                    let.Add(s[i]);
                    num.Add(count);
                    count = 1;
                }
                else count++;
            }
            if (let.Count != num.Count) num.Add(count);
            for (int i = 0; i < let.Count; i++)
                concatStr += $"{num[i]}{let[i]}";

            return concatStr.Replace("1", "");
        }
        static void Main(string[] args)
        {
            //string inp = "bbc";
            //isBeautifulString(inp);
            // electionsWinners(arr, 3);
            //string mac = "AB-CD-EF-12-34_56";
            //isMAC48Address(mac);
            string s = "aabbbc";
            Console.WriteLine(lineEncoding(s));
        }
    }
}
