using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortByHeight
{
    class Program
    {
        public static int[] sortByHeight(int[] a)
        {
            List<int> sortList=new List<int>();
            List<int> indexList=new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]==-1)
                {
                    indexList.Add(i);
                }
                else
                {
                    sortList.Add(a[i]);
                }
            }
            sortList.Sort();
            int[] arr = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                if (indexList.Contains(i))
                {
                    arr[i] = -1;
                }
                else
                {
                    arr[i] = sortList.FirstOrDefault();
                    sortList.Remove(arr[i]);
                }
            }
            return arr;
        }

        static void Main(string[] args)
        {
            int[] a = {-1, 150, 190, 170, -1, -1, 160, 180};
            int [] arrayByHeight = sortByHeight(a);
            for (int i = 0; i < arrayByHeight.Length; i++)
            {
                Console.WriteLine(arrayByHeight[i]+ " ");
            }
        }
    }
}
