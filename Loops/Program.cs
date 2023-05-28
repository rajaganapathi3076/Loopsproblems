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

            Console.WriteLine("For loops problems 4"); 
            Console.WriteLine("Input the value of terms");
            int n=int.Parse(Console.ReadLine());

            int sum = 0;
            for(int i=0; i<=n; i++)
            {
               
                Console.Write(" {0} ",i);
                sum += i;


            }
            Console.Write("\n The sum of the natural number upto {0} terms : {1}\n",n, sum);
          
        }
        
    }
}
