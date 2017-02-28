using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputAnagramSeries;
            string[] inputAnagramSeriesArray=new string[50];
            label:
            Console.WriteLine("Enter the anagram series(seperated by comma)");
            inputAnagramSeries = Console.ReadLine();
            if (inputAnagramSeries == "")
            {
                Console.WriteLine("Enter string set");
                goto label;
            }

            inputAnagramSeriesArray = inputAnagramSeries.Split(',');
            for (int i = 0; i < inputAnagramSeriesArray.Length; i++)
            {
                Console.Write(" "+inputAnagramSeriesArray[i]);
            }
            bool checkValidation = InputValidation.inputAnagramSeriesArrayValidation(inputAnagramSeriesArray);
            if (!checkValidation)
            {
                goto label;
            }
            int anagramSubset = CheckAnagramSubset.GetMaximumSubset(inputAnagramSeriesArray);
            Console.WriteLine("\nSubset:"+anagramSubset);
        }
    }
}
