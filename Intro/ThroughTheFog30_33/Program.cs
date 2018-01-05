using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThroughTheFog30_33
{
    class Program
    { //30
        public static int circleOfNumbers(int n, int firstNumber)
        {
            int RadiallyOppositePosition = firstNumber + n / 2;
            if (RadiallyOppositePosition >= n)
            {
                RadiallyOppositePosition -= n;
            }

            return RadiallyOppositePosition;
        }
        //31
        public static int depositProfit(int deposit, int rate, int threshold)
        {
            int count = 0;
            double incDeposit = deposit;
            while (incDeposit < threshold)
            {
                count++;
                incDeposit += incDeposit * rate / 100;
            }
            return count;
        }
        //32
        public static int absoluteValuesSumMinimization(int[] a)
        {
            int[] absArr=new int[a.Length];
            int possValue = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    possValue += Math.Abs(a[j] - a[i]);
                }
                absArr[i] = possValue;
                possValue = 0;
            }
            int minValue = absArr.Min();
            int minIndex = 0;
            for (int i = 0; i < absArr.Length; i++)
            {
                if (minValue == absArr[i])
                {
                    minIndex = i; 
                    break;
                }
            }

            return a[minIndex];
        }
        //33
        public static bool ISOne(string[] inputArray)
        {
            string s1 = "";
            string s2 = "";
            int count = 0;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                s1 = inputArray[i];
                s2 = inputArray[i + 1];
                count = 0;
                for (int j = 0; j < inputArray[i].Length; j++)
                {
                    if (s1[j] != s2[j])
                        count++;
                    if (count > 1)
                        return false;
                }
                if (count == 0)
                    return false;

            }
            return true;
        }
        public static  bool stringsRearrangement(string[] inputArray)
        {
            if (ISOne(inputArray))
            {
                return true;
            }
            else
            {
                List<string> list = inputArray.ToList();
                list.Sort();
                inputArray = list.ToArray();
                return ISOne(inputArray);
            }           
        }
        static void Main(string[] args)
        {
            //30
            //int n = 10;
            //int fN = 7;
            //Console.WriteLine(circleOfNumbers(n,fN));
            //31
            //int deposit = 20;
            //int rate = 10;
            //int threshold = 50;
            //int year = depositProfit(deposit, rate, threshold);
            //Console.WriteLine(year);
            //32
            //int[] arr = { 1, 1, 3, 4 };
            //Console.WriteLine(absoluteValuesSumMinimization(arr));
            //33
            string[] inputArray = {"abc",
                "abx",
                "axx",
                "abx",
                "abc"};
            Console.WriteLine(stringsRearrangement(inputArray));
            
        }
    }
}
