using System;
using System.Runtime.InteropServices;

namespace Greater_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numm1 = int.Parse(Console.ReadLine());
            int numm2 = int.Parse(Console.ReadLine());

            if (numm1 > numm2)
            {
                Console.WriteLine(numm1);
            }
                
            else
            {
                Console.WriteLine(numm2);
            }
            
        }
    }
}
