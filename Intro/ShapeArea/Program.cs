using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    class Program
    {   static int shapeArea(int n)
        {
            if (n==1)
            {
                return 1;
            }
            int S = 0;
            S = 2 * n + 2 * (n - 2);
            n --;
            if (n!=1)
            {
                S+=shapeArea(n)-1;
            }
            
            return S+1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(shapeArea(3));
            Console.ReadKey();
        }
    }
}
