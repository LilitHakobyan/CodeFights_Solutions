using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayChange
{
    class Program
    {
       static  int arrayChange(int[] inputArray)
       {
           int count = 0;
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i - 1] >= inputArray[i])
                {
                    inputArray[i]++;
                    i--;
                    count++;
                }
            }
           for (int i = 0; i < inputArray.Length; i++)
           {
               Console.Write($"{inputArray[i]}   ");
           }
            return count;
       }
        static void Main(string[] args)
        {
            int[] arr = {1,1,1};
            int count = arrayChange(arr);
        }
    }
}
