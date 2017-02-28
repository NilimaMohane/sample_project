using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionOfAlphabetNumberOfCharacterIsPrime
{
   interface IConvertString
    {
        string ConvertStringToLowerCase(string inputString);
        string ConvertStringToUpperCase(string inputString);
        char[] ConvertStringToCharArray(string inputString);
    }
}
