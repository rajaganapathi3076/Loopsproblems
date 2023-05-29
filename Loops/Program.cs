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
            //Printing the array charcters in for eachloop

            Console.WriteLine("for each loops problems 1");

            char[] chars =  { 'a', 'b', 'c', 'd', 'e' };

            foreach (char c in chars)
            {
                Console.Write(" {0} ",c);
            }
          
        }
        
    }
}
