using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commonCharacterCount
{
    class Program
    {
        public static int commonCharacterCount(string s1, string s2)
        {
            int count = 0;
            List<int> s2Set=new List<int>();
            for (int i = 0; i < s2.Length; i++)
            {
                s2Set.Add(s2[i]);
            }
            for (int i = 0; i < s1.Length; i++)
            {

                if (s2Set.Contains(s1[i]))
                {
                    s2Set.Remove(s1[i]);
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            string s1 = "aabcc";
            string s2 = "adcaa";
            Console.WriteLine(commonCharacterCount(s1, s2));
        }
    }
}
