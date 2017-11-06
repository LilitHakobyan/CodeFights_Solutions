using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makeArrayConsecutive2
{
    class Program
    {
        public static int makeArrayConsecutive2(int[] statues)
        {
           int min = statues.Min();
           int max = statues.Max();
            int count = 0;
            while (min!=max)
            {
                if (!statues.Contains(min+1))
                {
                   count++;
                }
                min = min + 1;
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] statues = {6, 2, 3, 8};
            Console.WriteLine(makeArrayConsecutive2(statues));
            
        }
    }
}
