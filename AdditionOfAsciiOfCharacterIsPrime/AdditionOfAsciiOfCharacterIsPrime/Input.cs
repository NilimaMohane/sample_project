using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionOfAlphabetNumberOfCharacterIsPrime
{
    class Input
    {
        private string inputString;
        public string InputFromUser()
        {
            Console.WriteLine("Enter String:");
            inputString = Console.ReadLine().Trim();
            return inputString;
        }
    }
}
