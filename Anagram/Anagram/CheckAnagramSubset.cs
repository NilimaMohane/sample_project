using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class CheckAnagramSubset
    {
        public static int GetMaximumSubset(string[] s)
        {
            StringBuilder elementString = new StringBuilder();
            int sLength = s.Length;
            for (int i = 0; i < sLength; i++)
            {
                elementString.Clear();
                char[] element = s[i].ToArray<char>();
                Array.Sort(element);
                foreach (char ch in element)
                {
                    elementString.Append(ch);
                }
                s[i] = elementString.ToString();
            }
            Array.Sort(s);
            string[] sDistict = s.Distinct().ToArray<string>();
            int anagramSubset = sDistict.Length;
            #region only for distict Array
            /*  int flag = 1;
              int[] elementLength=new int[s.Length];
              for (int i=0;i<s.Length;i++)
              {
                  elementLength[i] = s[i].Length;
              }
              int[] elementDistictLength = elementLength.Distinct<int>().ToArray<int>();
              if(elementLength.Length==elementDistictLength.Length)
              {

                  flag = 0;
                  return flag;
              }
              */
            #endregion
            return anagramSubset;
        }
    }
}
