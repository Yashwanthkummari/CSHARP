using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    internal class Class23secondlargestnumber
    {
        public void largestnumber()
        {
            Console.WriteLine("enter size of an a array");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("enter" + size + "elements");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("elements-{0}", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            int largestnum = 0;
            int secondlargestnum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > largestnum)
                {
                    secondlargestnum = largestnum;
                    largestnum = array[i];
                }

                else if (array[i] > secondlargestnum && array[i] != largestnum)
                {
                    secondlargestnum = array[i];


                }
            }
                Console.WriteLine(secondlargestnum);
                Console.ReadLine();
            
        }
    }
}