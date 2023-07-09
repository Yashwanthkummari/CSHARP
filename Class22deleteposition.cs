using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    internal class Class22deleteposition
    {
        public void meth21()
        {
            Console.WriteLine("enter size of array:");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("enter the elements:");
            for (int i = 0;i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter the position where to delete");
            int position = int.Parse(Console.ReadLine());
            {
                int[] newarray= new int[size -1];
                int newarrayindex = 0;
                for(int i=0;i < array.Length;i++)
                {
                    if (array[i] != position)
                    {
                        newarray[newarrayindex] = array[i];
                        newarrayindex++;

                    }
                }
                Console.WriteLine("the new list is:");
                for(int i=0; i < newarray.Length; i++)
                {
                    Console.WriteLine(newarray[i] +"");
                }
                Console.ReadLine();
            }
        }
    }
}
