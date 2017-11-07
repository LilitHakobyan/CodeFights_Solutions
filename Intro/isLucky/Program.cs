using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isLucky
{
    class Program
    {
        public  static bool isLucky(int n)
        {
           ArrayList listOfDigets=new ArrayList();
            int sum1 = 0;
            int sum2 = 0;
            while (n!=0)
            {
                listOfDigets.Add(n % 10);
                n = n / 10;
                
            }
            for (int i = 0; i < listOfDigets.Count/2; i++)
            {
                sum1 +=(int)listOfDigets[i];
                sum2 += (int) listOfDigets[listOfDigets.Count - i-1];
            }
            return sum2==sum1;
        }

        static void Main(string[] args)
        {
            int n = 239017;
            Console.WriteLine(isLucky(n));
        }
    }
}
