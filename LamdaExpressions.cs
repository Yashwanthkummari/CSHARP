using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class LamdaExpressions
    
        {
            static void main(string[] args)
            {
                
                List<int> numbers = new List<int>() {1, 3, 12, 15, 9, 18, 36, 47, 9, 31};

                Console.Write("The list : ");
                foreach (var value in numbers)
                {
                    Console.Write("{0} ", value);
                }
                Console.WriteLine();

                var square = numbers.Select(x => x * x);
    
                Console.Write("Squares : ");
                foreach (var value in square)
                {
                    Console.Write("{0} ", value);
                }
                Console.WriteLine();

                List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0);
            
                Console.Write("Numbers Divisible by 3 : ");
                foreach (var value in divBy3)
                {
                    Console.Write("{0} ", value);
                }
                Console.WriteLine();
            }
        }
    }


