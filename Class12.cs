using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    internal class Class12
    {
        public void meth11()
        {
            Console.WriteLine("enter a number");
            int number = int.Parse(Console.ReadLine());
            long fact = 1;
            
            for (int i = 1; i<=number; i++) 
            { 
                fact *= i;
            }

            Console.WriteLine("the factorial of:" +number+ "is" +fact);
            Console.ReadLine();

        }
    }
}
