using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class InputValidation
    {

        public static bool inputAnagramSeriesArrayValidation(string[] inputAnagramSeriesArray)
        {
            bool checkElementLength = inputAnagramSeriesArrayElementLengthValidation(inputAnagramSeriesArray);
            if (checkElementLength == false)
            {
                Console.WriteLine("\nEach string contains only 50 characters");
                return false;
            }

            bool checkLowerCaseAlphabet = inputAnagramSeriesArrayOnlyLowerCaseAlphabet(inputAnagramSeriesArray);
            if (checkLowerCaseAlphabet == false)
            {
                Console.WriteLine("\nEnter only lower alphabets");
                return false;
            }

            bool checkDistictArray = inputAnagramSeriesDistictArray(inputAnagramSeriesArray);
            if (checkDistictArray == false)
            {
                Console.WriteLine("\nEnter Distict string");
                return false;
            }
            return true;
        }

        private static bool inputAnagramSeriesArrayElementLengthValidation(string[] inputAnagramSeriesArray)
        {
            for (int i = 0; i < inputAnagramSeriesArray.Length; i++)
            {
                if (inputAnagramSeriesArray[i].Length > 50)
                {
                    return false;
                }
            }
            return true;
        }

        private static bool inputAnagramSeriesArrayOnlyLowerCaseAlphabet(string[] inputAnagramSeriesArray)
        {
            for (int i = 0; i < inputAnagramSeriesArray.Length; i++)
            {
                foreach (char s in inputAnagramSeriesArray[i])   
                {
                    if (!(s >= 'a' && s <= 'z'))
                    {
                        return false;
                    }
                   
                }
            }
            #region Check Alpabet using isLower Method
            /* for (int i = 0; i < inputAnagramSeriesArray.Length; i++)
            {
                foreach (char s in inputAnagramSeriesArray[i])
                {
                    if (Char.IsLower(s))
                    {
                        return true;
                    }
                    else
                        return false;
                }

            }
               */
            #endregion
            return true;
        }

        private static bool inputAnagramSeriesDistictArray(string[] inputAnagramSeriesArray)
        {
            string[] inputDistictArray = inputAnagramSeriesArray.Distinct<string>().ToArray<string>();
            if (inputAnagramSeriesArray.Length != inputDistictArray.Length)
            {
                return false;
            }
            return true;

        }
    }
}
