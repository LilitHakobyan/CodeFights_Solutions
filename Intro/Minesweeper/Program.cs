using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class Program
    {
        public static int[][] minesweeper(bool[][] matrix)
        {
            int[][] resMatrix = new int[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                resMatrix[i] = new int[matrix[i].Length];
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    int count = 0;
                    try
                    {
                        if (matrix[i - 1][j - 1])
                            count++;
                    }
                    catch { }
                    try
                    {
                        if (matrix[i][j - 1])
                            count++;
                    }
                    catch { }
                    try
                    {
                        if (matrix[i + 1][j - 1])
                            count++;
                    }
                    catch { }
                    try
                    {
                        if (matrix[i - 1][j])
                            count++;
                    }
                    catch { }
                    try
                    {
                        if (matrix[i + 1][j])
                            count++;
                    }
                    catch { }
                    try
                    {
                        if (matrix[i - 1][j + 1])
                            count++;
                    }
                    catch { }
                    try
                    {
                        if (matrix[i][j + 1])
                            count++;
                    }
                    catch { }
                    try
                    {
                        if (matrix[i + 1][j + 1])
                            count++;
                    }
                    catch { }
                    resMatrix[i][j] = count;
                }
            }
            return resMatrix;
        }

        static void Main(string[] args)
        {
            bool[][] matrix1 =
            { new []  {true,false,false,true},
                new [] { false,false,true,false},
                new [] {true,true,false,true},
            };
            bool[][] matrix =
            {   new []  {true, false, false},
                new [] { false, true, false},
                new [] {false, false, false},
            };
            int[][] resMatrix = minesweeper(matrix1);

            for (int i = 0; i < resMatrix.Length; i++)
            {
                for (int j = 0; j < resMatrix[i].Length; j++)
                {
                    Console.Write("{0}{1}", resMatrix[i][j], j == (resMatrix[i].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
            }
        }
    }
}

