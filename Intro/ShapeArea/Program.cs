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
            int S = 1;
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
            Console.WriteLine(shapeArea(3));
            Console.ReadKey();
        }
    }
}
