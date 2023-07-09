using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    internal class Class15
    {
        public void meth14()
        {
            Console.WriteLine("enter a number");
            int number = int.Parse(Console.ReadLine());
            string result = number.ToString();
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("plingplang");
                }

                else if (number % 3 == 0)
                {
                    Console.WriteLine("pling");
                }
                else if(number % 5 == 0)    
                {
                    Console.WriteLine("plang");
                }
                if (number % 7 == 0)
                {
                    Console.WriteLine("plong");
                }
                    if (number % 3 != 0 && number % 5 != 0 && number % 7 != 0)
                    {
                        Console.WriteLine(number + "is not is a factor of 3 5 7 ");
                    }
                }
                        Console.ReadKey();
                    }
                }
            }
        

    


