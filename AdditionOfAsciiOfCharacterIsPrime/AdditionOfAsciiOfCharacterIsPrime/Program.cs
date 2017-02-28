using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionOfAlphabetNumberOfCharacterIsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input();
            ConvertString convertString = new ConvertString();

            string inputString, inputStringInLowerCase;
            bool inputStringIsValidate, isPrimeNumber;
            char[] inputStringCharArray;
            int sumOfAlphabet;

            do
            {
                inputString = input.InputFromUser();
                inputStringIsValidate = StringValidation.inputStringValidate(inputString);
            } while (inputStringIsValidate == false);

            inputStringInLowerCase = convertString.ConvertStringToLowerCase(inputString);

            inputStringCharArray = convertString.ConvertStringToCharArray(inputStringInLowerCase);

            sumOfAlphabet = SumOfCharacterArrayAlphabet.sumOfAlphabetOfLowerCaseAlphabet(inputStringCharArray);
            Console.WriteLine("sumOfAlphabet:" + sumOfAlphabet);

            isPrimeNumber = PrimeNumber.IsPrimeNumber(sumOfAlphabet);
            if (isPrimeNumber)
            {
                Console.WriteLine("Prime Number");
            }
            else
                Console.WriteLine("Not Prime Number");
        }
    }
}
