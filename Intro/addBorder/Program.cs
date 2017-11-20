using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addBorder
{
    class Program
    {
       public static string[] addBorder(string[] picture)
       {
           string [] result=new string[picture.Length+2];
           for (int i = 0; i < picture[0].Length+2; i++)
           {
               result[0] += "*";
           }
           result[result.Length - 1] = result[0];
           for (int i = 1; i < result.Length-1; i++)
           {
               result[i] += "*"+picture[i-1]+"*";
           }
            return result;
       }

        static void Main(string[] args)
        {
            string[] matrix = {"a"};
            string[] resilt = addBorder(matrix);
            for (int i = 0; i < resilt.Length; i++)
            {
                for (int j = 0; j < resilt[i].Length; j++)
                {
                    Console.Write($"{resilt[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
