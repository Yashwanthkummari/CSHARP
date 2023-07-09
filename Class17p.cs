using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    internal class Class17p
    {
        public void p17()
        {
            int[] a1 = new int[5];
            int count = 0;
            Console.WriteLine(" enter the numbers");
            for (int i = 0; i < 5; i++)
            {
                a1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0;i < a1[i]; i++)
            {
                for (int j = 1;j<= a1[i]; j++)
                {
                    if (a1[i]  % j == 0)
                    {
                        count++;
                    }
                }
                if (count<=2 && count!=0)
                {
                    Console.WriteLine(a1[i] + "is a prime number ");
                }
                Console.ReadKey();
            }
        }
    }
}
