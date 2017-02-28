using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionOfAlphabetNumberOfCharacterIsPrime
{
    class StringValidation
    {
        public static bool inputStringValidate(string inputString)
        {
            bool checkStringIsEmpty = inputStringIsEmpty(inputString);
            if (checkStringIsEmpty == false)
            {
                Console.WriteLine("String is Empty enter string first");
                return false;
            }
            bool checkOnlyAlphabet = inputStringOnlyContainsAlphabet(inputString);
            if (checkOnlyAlphabet == false)
            {
                Console.WriteLine("Only alphabet is required");
                return false;
            }
            return true;
        }
        public static bool inputStringIsEmpty(string inputString)
        {
            if (inputString.Length == 0)
            {
                return false;
            }
            return true;
        }
        public static bool inputStringOnlyContainsAlphabet(string inputString)
        {
            foreach (char character in inputString)
            {
                if (!Char.IsLetter(character) && character != 32)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
