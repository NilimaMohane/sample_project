using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionOfAlphabetNumberOfCharacterIsPrime
{
    class ConvertString: IConvertString
    {
       public  string ConvertStringToLowerCase(string inputString)
        {
            string inputStringInLowerCase= inputString.ToLower();
            return inputStringInLowerCase;
        }
       public string ConvertStringToUpperCase(string inputString)
        {
            string inputStringInUpperCase=inputString.ToUpper();
            return inputStringInUpperCase;
        }
      public char[] ConvertStringToCharArray(string inputString)
        {
            char[] inputStringArray = inputString.ToArray();
            return inputStringArray;
        }
    }
}
