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

            Console.WriteLine("While loops problems 3");
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            int i=0 ;
            int j=1;
            int k=0 ;
            Console.Write("{0} {1}", i, j);


                k = i + j;
            
            while (k <= n)
            {
                Console.Write(" {0} ", k);
                i++;
                i = j;
                j = k;
                k = i + j;
               
               
            }
            Console.ReadKey();
            
        }
        
    }
}
