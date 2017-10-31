using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentElementsProduct
{
    class Program
    {
        static  int AdjacentElementsProduct(int[] inputArray)
        {
            int largestProduct = 0;
            int thisProduct = 0;
            for (int i = 0; i < inputArray.Length-1; i++)
            {
                thisProduct = inputArray[i] * inputArray[i + 1];
                if (thisProduct>largestProduct)
                {
                    largestProduct = thisProduct;
                }
            }
            return largestProduct;

        }
        static void Main(string[] args)
        {
            int [] inputArray =  { 3, 6, -2, -5, 7, 3};
            Console.WriteLine(AdjacentElementsProduct(inputArray));
            Console.ReadKey();
        }
    }
}
