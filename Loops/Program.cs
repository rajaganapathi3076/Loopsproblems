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
            //Find the sum of first 10 natural numbers 

            Console.WriteLine("While loops problems 1");
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            int i, res;


            i = 0;
            while(i<=10)
            {
                res = n * i;
                Console.WriteLine("{0}x{1}={2}",i,n,res);
                i++;
            } 
            Console.ReadLine();
        }
        
    }
}
