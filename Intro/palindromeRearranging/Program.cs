using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromeRearranging
{
    class Program
    {
        static bool palindromeRearranging(string inputString)
        {
            List<char> inputList = inputString.Distinct().ToList();
            bool res = false;
            if (inputString.Length % 2 == 1)
            {
                for (int i = 0; i < inputList.Count; i++)
                {
                    int count = 0;
                    for (int j = 0; j < inputString.Length; j++)
                    {
                        if (inputString[j] == inputList[i])
                            count++;
                    }
                    if(count%2==1)
                    {
                        if (!res)
                        {
                            if (count == 1)
                                res = true;
                        }
                        else
                            return false;
                    }
            
                }
                return true;
            }
            for (int i = 0; i < inputList.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < inputString.Length; j++)
                {
                    if (inputString[j] == inputList[i])
                        count++;
                }

                if (count % 2 == 1)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            string inputStr = "zaa";
            Console.WriteLine(palindromeRearranging(inputStr));

        }
    }
}
