using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For loops problems 2");  // To Printing the tables
            Console.WriteLine("Please enter the number");
            int n=int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                Console.WriteLine("{0}x2={1}", i, (i * 2));
                
            }
        }
        
    }
}
