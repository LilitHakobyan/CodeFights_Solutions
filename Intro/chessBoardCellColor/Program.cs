using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessBoardCellColor
{
    class Program
    {
        public static bool chessBoardCellColor(string cell1, string cell2)
        {
            string L1 = "ACEG";
            string D1 = "1357";
            string L2 = "BDFH";
            string D2 = "2468";
            string thisCall;
            List<string> blackList=new List<string>();
            for (int i = 0; i < L1.Length; i++)
            {
                for (int j = 0; j < D1.Length; j++)
                {
                    thisCall = string.Concat(L1[i] , D1[j]);
                    blackList.Add(thisCall);
                }
            }
            for (int i = 0; i < L2.Length; i++)
            {
                for (int j = 0; j < D2.Length; j++)
                {
                    thisCall = string.Concat(L2[i] ,D2[j]);
                    blackList.Add(thisCall);
                }
            }
            if ((blackList.Contains(cell1)&&!blackList.Contains(cell2))||(! blackList.Contains(cell1) && blackList.Contains(cell2)))
            {
                return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            string cell1 = "A1";
            string cell2 = "H3";
            Console.WriteLine(chessBoardCellColor(cell1, cell2));

        }
    }
}
