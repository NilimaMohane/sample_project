using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionOfAlphabetNumberOfCharacterIsPrime
{
    class SumOfCharacterArrayAlphabet
    {
        public static int sumOfAlphabetOfLowerCaseAlphabet(char[] inputStringCharacterArray)
        {
            int sumOfAlphabet = 0;
            foreach (char character in inputStringCharacterArray)
            {
                if (character == 32)
                    continue;
                sumOfAlphabet += (character - 96);
            }
            return sumOfAlphabet;
        }
    }
}
