using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    internal class Class16presentabsent
    {
        public void meth15()
        {
            Console.Write("enter a string");
            string input = Console.ReadLine();

            bool hasA = input.Contains("a");
            bool hasE = input.Contains("e");
            bool hasP = input.Contains("p");
        if (hasA && hasE && hasP)
            {
                Console.WriteLine("All Are Present");
            }
        else if (hasA || hasE || hasP)
            {
                Console.WriteLine("one or more present");
            }
        else
            {
                Console.WriteLine("None Present");
                 
            }
        Console.ReadKey();
        }
        

    }
}
