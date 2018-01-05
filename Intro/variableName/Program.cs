using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace variableName
{
    class Program
    {
       public static  bool variableName(string name)
       {
           if (char.IsDigit(name, 0))
               return false;
            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetterOrDigit(name, i) )
                { if(name[i] != '_')
                    return false;
                }
            }
           return true;
       }
        bool variableName1(string name)
        {
            var regex = new Regex(@"^[a-zA-Z_][a-zA-Z_\d]*$");
            return regex.IsMatch(name);
        }
       public static  string alphabeticShift(string inputString)
       {
           string replacedSt = string.Empty;
            for (int i = 0; i < inputString.Length; i++)
            {
                int ansi =  inputString[i];
                if (ansi == 122)
                {
                    replacedSt += (char)97;
                }
                else
                {
                    replacedSt += (char)(ansi + 1);
                }
            }
           return replacedSt;
       }

        static void Main(string[] args)
        {
            //string name = "var_1__Int";
            //Console.WriteLine(variableName(name));
            string inputString = "azzy";
            Console.WriteLine(alphabeticShift(inputString));

        }

    }
}
