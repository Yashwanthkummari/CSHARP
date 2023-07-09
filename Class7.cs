using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    class Class7
    {
        public void meth6()
        {
            Random random = new Random();
            int[] ints = new int[5];

            for (int i = 0; i < ints.Length; i++) 

            {
                ints[i] = random.Next(10 , 51);


            }
            Console.WriteLine("generated numbers:" + string.Join("", ints));
                int sum = 0;
                for(int i=0;i<ints.Length; i++)

                {
                    sum += ints[i];

                }
                double average = sum / ints.Length;
            Console.WriteLine(average);
            Console.ReadLine();
            }
        }
    }
