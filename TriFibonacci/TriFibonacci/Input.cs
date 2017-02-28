using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriFibonacci
{
    class Input
    {
        public int[] CompleteInput()
        {
            Validation validation = new Validation();
            string inputString;
            string[] inputstr;
            int[] input;
            bool checkMinus;
        label:
            Console.WriteLine("Enter Input array");
            inputString = Console.ReadLine();
            inputstr = inputString.Split(',');
            input = validation.InputValidationWithoutMinusCheck(inputstr);

            if (input == null)
            {
                goto label;
            }
            checkMinus = validation.CountMinusOne(input);
            if (checkMinus == false)
            {
                return null;
            }
            else
            {
                return input;
            }
        }
    }
}

