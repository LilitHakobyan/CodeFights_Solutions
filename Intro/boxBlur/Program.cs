using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxBlur
{
    class Program
    {
       public static int[][] boxBlur(int[][] image)
       {
         int resLenght=  image.Length - 2;
           int minlengh = image[0].Length;

           for (int i = 0; i < image.Length; i++)
           {
             minlengh=  Math.Min(image[i].Length, minlengh);
           }
           int[][] resImg = new int[resLenght][];

            for (int i = 0; i < image.Length-2; i++)
           {
               resImg[i] = new int[minlengh-2];
                for (int j = 0; j < image[i].Length - 2; j++)
               {
                    //if(resImg[i]==null)
                    //    resImg[i]=new int[j+1];
                    resImg[i][j] = (image[i][j] + image[i][j + 1] + image[i][j + 2]
                                  + image[i + 1][j] + image[i + 1][j + 1] + image[i + 1][j + 2]
                                  + image[i + 2][j] + image[i + 2][j + 1] + image[i + 2][j + 2])/9;
               }
              
           }


            return resImg;
       }

        static void Main(string[] args)
        {
            int[][] image =
            { new []  {7, 4, 0, 1},
              new [] { 5, 6, 2, 2},
              new [] { 6, 10, 7, 8},
              new [] { 1, 4, 2, 0}
            };
            //int[][] image =
            //{   new []  {1, 1, 1},
            //    new [] { 1, 7, 1},
            //    new [] { 1, 1, 1},
            //};
            int[][] resMatrix = boxBlur(image);

            for (int i = 0; i < resMatrix.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < resMatrix[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", resMatrix[i][j], j == (resMatrix[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
        }

    }
}
