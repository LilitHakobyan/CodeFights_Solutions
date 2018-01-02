using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areEquallyStrong
{
    class Program
    {
       public static bool areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {
            if (yourLeft >= yourRight)
            {
                if (friendsLeft >= friendsRight)
                {
                    if (yourLeft == friendsLeft && yourRight == friendsRight)
                        return true;
                }
                else
                {
                    if (yourLeft == friendsRight && yourRight == friendsLeft)
                        return true;
                }
            }
            else
            {
                if (friendsLeft >= friendsRight)
                {
                    if (yourRight == friendsLeft && yourLeft == friendsRight)
                        return true;
                }
                else
                {
                    if (yourRight == friendsRight && yourLeft == friendsLeft)
                        return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
        }
    }
}
