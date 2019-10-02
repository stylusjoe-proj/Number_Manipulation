using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Helper
    {
        public void AddToVals(ref int input1, ref int input2, int increment)
        {
            input1 += increment;
            input2 += increment;
        }

        public void Swap(ref int input1, ref int input2)
        {
            int placeInput1 = input1;
            int placeInput2 = input2;
            input1 = placeInput2;
            input2 = placeInput1;
        }
    }
}
