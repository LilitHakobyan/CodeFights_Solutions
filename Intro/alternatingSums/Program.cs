using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alternatingSums
{
    class Program
    {
        public  static int[] alternatingSums(int[] a)
        {
            int team1Sum = a[0];
            int team2Sum = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (i % 2 == 0)
                    team1Sum += a[i];
                if (i % 2 == 1)
                    team2Sum += a[i];
            }
            return new [] {team1Sum, team2Sum};
        }
        static void Main(string[] args)
        {
            int[] arrpeople = {80};
            int[] result = alternatingSums(arrpeople);
            Console.WriteLine($"1team  {result[0]} and 2team  {result[1]}");
        }
    }
}
