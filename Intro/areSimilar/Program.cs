using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areSimilar
{
    class Program
    {
        static bool isEqual(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }
        static void Swap(ref int lhs, ref int rhs)
        {
            int temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        public static bool areSimilarF(int[] a, int[] b)
        {
            if (a.Length != b.Length)
                return false;
            if (isEqual(a, b))
                return true;
            for (int j = 0; j < a.Length; j++)
            {
                for (int i = j+1; i < a.Length ; i++)
                {
                    Swap(ref a[j], ref a[i]);
                    if (isEqual(a, b))
                        return true;
                    Swap(ref a[j], ref a[i]);
                }
            }
            for (int j = 0; j < b.Length; j++)
            {
                for (int i = j + 1; i < b.Length ; i++)
                {
                    Swap(ref b[j], ref b[i]);
                    if (isEqual(a, b))
                        return true;
                    Swap(ref a[j], ref a[i]);
                }
            }
            return false;
        }
        bool areSimilar1(int[] a, int[] b)
        {
            List<int> m = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    m.Add(a[i]);
                    m.Add(b[i]);
                }
            }
            if (m.Count== 0)
                return true;
            if (m.Count == 4)
            {
                if (m[3] == m[0] && m[2] == m[1])
                    return true;
            }
            return false;
        }


        static void Main(string[] args)
        {
            int[] a = { 2, 3, 1 };
            int[] b = { 1, 3, 2 };
            Console.WriteLine($"{areSimilarF(a, b)}");
            Console.ReadKey();
        }
    }
}
