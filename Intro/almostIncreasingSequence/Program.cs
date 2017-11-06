using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almostIncreasingSequence
{
    class Program
    {
        public static bool almostIncreasingSequence(int[] sequence)
        {
            int count = 0;
            for (int i = 0, j = 1; j < sequence.Length; j++)
            {
                if (sequence[i] >= sequence[j])
                {
                    count++;
                    if (j > 1)
                    {
                        if (sequence[i - 1] < sequence[j])
                        {
                            i = j;
                            continue;
                        }
                        continue;
                    }
                }
                i = j;
            }

            return count <= 1;
        }
         static void Main(string[] args)
        {
            int[] seq = { 1, 2, 5, 3, 5};
            Console.WriteLine(almostIncreasingSequence(seq));
        }
    }
}
