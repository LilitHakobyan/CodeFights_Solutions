using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avoidObstacles
{

    class Program
    {
        public static int avoidObstacles(int[] inputArray)
        {
            int res = 0;
            List<int> listInput= inputArray.ToList();
            listInput.Sort();
            for (int i = 1; i <= listInput[inputArray.Length-1]; i++)
            {
                // res = listInput[i] + 1;
                res = i+1;
                for (int j = 1; j <= listInput[inputArray.Length - 1]; j++)
                {
                    if(listInput.Contains(res*j))
                        break;
                    if (j == listInput[inputArray.Length - 1])
                        return res;
                }

            }
           return res;
        }

        static void Main(string[] args)
        {
            int[] arr = { 19, 32, 11, 23 };
            int count = avoidObstacles(arr);
            Console.WriteLine(count);
        }
    }
}
