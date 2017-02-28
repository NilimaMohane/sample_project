using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionOfAlphabetNumberOfCharacterIsPrime
{
    class PrimeNumber
    {
        public static bool IsPrimeNumber(int number)
        {
            int checkPrime = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    checkPrime++;
                }
            }
            if (checkPrime > 1)
            {
                return false;
            }
            return true;
        }
    }
}
