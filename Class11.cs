using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    internal class Class11
    {
        public void meth10()
        {
            int start = 2000;
            int end = 3200;
            bool isTrue = true;
            for (int i = start; i <= end; i++)
            {
                if (i % 7 == 0 && i % 5 != 0) 
                {
                    if (!isTrue)
                    {
                        Console.Write(",");
                    }
                }
                Console.Write(i);
                isTrue = false;
                
                Console.ReadLine();     

            
            }
        }
    }
}
