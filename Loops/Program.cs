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

            Console.WriteLine("While loops problems 2");
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            int i;


            i = 2;
            while (i <= n)
            {
                Console.WriteLine("{0}", i);
                i = i + 2;
               
            } 
            Console.ReadLine();
        }
        
    }
}
