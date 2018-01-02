using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace isIPv4Address
{
    class Program
    {
       public static bool isIPv4Address(string inputString)
       {
           string[] ip = inputString.Split('.');
           if (ip.Length != 4)
               return false;
           for (int i = 0; i < ip.Length; i++)
           {

               try
               {
                   int thisItem = Int32.Parse(ip[i]);
                   if (thisItem < 0 || thisItem > 255)
                       return false;
                }
               catch (Exception e)
               {
                   return false;
                }
           }
           return true;
       }

        static void Main(string[] args)
        {
            string inputString = "1.256.1.1";
            bool res=isIPv4Address(inputString);
            Console.WriteLine(res);
        }
    }
}
