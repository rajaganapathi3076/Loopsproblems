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
            Console.WriteLine("For loops problems 3");  // To Check prime number
            Console.WriteLine("Please enter the number");
            int number=int.Parse(Console.ReadLine());
            int result=0;
            for(int i=0; i<=number; i++)
            {
                if (number %2 == 0)
                {
                    result = 1;
                    break;
                  
                }


            }
            if (result == 0)
            {
                Console.WriteLine("The number  {0} is prime", number);
            }
            else
            {
                Console.WriteLine("The number is {0} is a not prime", number);
            }
            {

            }
        }
        
    }
}
