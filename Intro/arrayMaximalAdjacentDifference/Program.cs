using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayMaximalAdjacentDifference
{
    class Program
    {
       public static int arrayMaximalAdjacentDifference(int[] inputArray)
       {
           int sub = 0;
           for (int i = 0; i < inputArray.Length-1; i++)
           {
               if (Math.Abs(inputArray[i+1]-inputArray[i])>sub)
               {
                   sub = Math.Abs(inputArray[i + 1] - inputArray[i]);
               }
           }
           return sub;
       }
        static void Main(string[] args)
        {
        }
    }
}
