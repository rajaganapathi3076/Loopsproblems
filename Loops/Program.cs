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
            Console.WriteLine("For loops problems");
            Console.WriteLine("Please enter the number");
            int x=int.Parse(Console.ReadLine());

            for(int i=1; i<=x; i++)
            {
                Console.Write(" {0} ", i);
            }
        }
    }
}
