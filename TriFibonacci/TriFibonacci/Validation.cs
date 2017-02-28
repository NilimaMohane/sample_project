using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriFibonacci
{
    class Validation
    {

       public int[] InputValidationWithoutMinusCheck(string[] inputstr)
        {
            int input, i;
            int inputstrLength = inputstr.Length;
            int[] inputArray = new int[inputstrLength];
            #region Checking valid Input Without Minus Checking
            if (inputstrLength > 3)
            {
                for (i = 0; i < inputstrLength; i++)
                {
                    if (int.TryParse(inputstr[i], out input))
                    {
                        if (i > 19)
                        {
                            Console.WriteLine("Enter minimum 4 element and maximum 20");
                            return null;
                        }
                        if ((input >= 1 && input <= 1000000) || input == -1)
                        {
                            inputArray[i] = input;
                        }
                        else
                        {
                            Console.WriteLine("Enter valid element");
                            return null;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter valid element");
                        return null;
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter minimum 4 element and maximum 20");
                return null;
            }
            return inputArray;
            #endregion
        }
        public bool CountMinusOne(int[] inputArrayElement)
        {
            int count = 0;
            for (int i = 0; i < inputArrayElement.Length; i++)
            {
                if (inputArrayElement[i] == -1)
                {
                    count++;
                }
            }
            if (count > 1)
            {
                Console.WriteLine("Enter -1 only one time");
                return false;
            }
            else if (count == 0)
            {
                Console.WriteLine("Enter -1 atleast one time");
                return false;
            }
            return true;
        }
    }
}

