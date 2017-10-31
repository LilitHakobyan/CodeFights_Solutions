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
                return 0;
            }
            int S = 0;
            S = 2 * n + 2 * (n - 2);
            n -= 1;
            if (n!=1)
            {
                S+=shapeArea(n);
            }
            
            return S;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(shapeArea(3)+1);
            Console.ReadKey();
        }
    }
}
