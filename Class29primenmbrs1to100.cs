using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    internal class Class29primenmbrs1to100
    {
        public void primenumber()
        {
            Console.WriteLine("print prime numbers between 1-100:");
            int startingnumber = int.Parse(Console.ReadLine());
            int endingnumber = int.Parse(Console.ReadLine());
            for (int i = startingnumber; i <= endingnumber; i++)
            {
                int count = 0;
                for (int j = 1; j <= endingnumber; j++)
                {
                    if (i % 2 == 0)
                        count++;

                    else if (count <= 2 && count != 0)
                        Console.WriteLine(i + "" + "");
                }
                Console.ReadLine();
            }
        }
    }
}
