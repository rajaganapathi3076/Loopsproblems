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

            int sum = 0;
            for(int i=0; i<=10; i++)
            {
               sum=sum+i;
                Console.WriteLine(i);


            }Console.Write("\n The sum is :{0}\n", sum);
          
        }
        
    }
}
