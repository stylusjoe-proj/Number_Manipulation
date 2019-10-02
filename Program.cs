using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
                Helper myInstance = new Helper();

                int input1 = 10;
                int input2 = 20;

                Console.WriteLine("AddToVals...");
                Console.WriteLine("\tCalling with val1 = {0}, val2 = {1}", input1, input2);

            Console.WriteLine("Input value for AddToVals increment...");
            int val = Convert.ToInt32(Console.ReadLine());
            myInstance.AddToVals(ref input1, ref input2, val);
                Console.WriteLine("After AddToVals has been called...");
                Console.WriteLine("\tval1 is now {0}, val2 is now = {1}", input1, input2);
                myInstance.Swap(ref input1, ref input2);
                Console.WriteLine("After SwapVals has been called...");
                Console.WriteLine("\tval1 is now {0}, val2 is now = {1}", input1, input2);
                Console.WriteLine("Press any key to continue...");
                Console.Read();
            
        }
    }
}
