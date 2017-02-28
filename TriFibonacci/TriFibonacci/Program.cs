using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriFibonacci
{
    class Tribonacci
    {

        static void Main(string[] args)
        {
            CheckTriFibonacci checkTriFibonacci = new CheckTriFibonacci();
            Input input = new Input();
            int NumberInsteadOfMinusOne=0;
            int[] A = input.CompleteInput();
            if (A != null)
            {
                 NumberInsteadOfMinusOne=checkTriFibonacci.Complete(A);
            }
            if (NumberInsteadOfMinusOne != 0)
            {
                Console.WriteLine("Number instead of -1 is:" + NumberInsteadOfMinusOne);
            }
            else
                Console.WriteLine("-1");

        }
    }
}
