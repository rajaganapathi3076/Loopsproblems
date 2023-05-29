using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Printing the even numbers in while lops 

            Console.WriteLine("While loops problems 5");
            int a = 1;
            while (a <= 5)
            {
                int b = 1;
                while (b <= 5)
                {
                    Console.Write(b + " ");
                    b++;
                }
                Console.WriteLine();
                a++;
            }
            Console.ReadKey();

        }
        
    }
}
