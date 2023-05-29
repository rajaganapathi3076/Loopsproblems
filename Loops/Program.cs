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
           
            

             
            
            while (i <= n)
            {
                Console.WriteLine();
               int  j = 1;
               
                
                while(j<=i)
                {
                    Console.Write( j + " ") ; 
                    j++;
                }
               i++;
               
            }
            Console.ReadKey();
            
        }
        
    }
}
