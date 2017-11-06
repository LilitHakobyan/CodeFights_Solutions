using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixElementsSum
{
    class Program
    {
        public static  int matrixElementsSum(int[][] matrix)
        {
            int sum = 0;
            List<int> indexList=new List<int>();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j]==0)
                    {
                        indexList.Add(j);
                        continue;


                    }
                    else if (indexList.Contains(j))
                    {
                        continue;
                    }
                    sum += matrix[i][j];

                } 
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int[][] matrix = new int [3][];
            matrix[0] = new int[] {0, 1, 1, 2};
            matrix[1] = new int[] { 0, 5, 0, 0};
            matrix[2] = new int[] { 2, 0, 3, 3};
   
            Console.WriteLine(matrixElementsSum(matrix));
        }
    }
}
