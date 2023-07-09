using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    internal class Class18arrayprimenumbers
    {
        public void meth17()
        {
            
            int[] numbers = { 3, 5, 7, 11, 12, 14, 19, 23, 25 };
               
            for (int i  = 0; i <numbers[i]; i++)

            {
                int count = 0;
                for (int j = 1; j <= numbers[i]; j++)
                {
                    if (numbers[i] % j  == 0)
                    {
                        count++;
                    }
                }
                if (count <= 2 && count !=0)
                {
                    Console.Write(numbers[i]+"");
                }
            }
            Console.ReadLine();
        }
    }
}
