using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    internal class Class19shift0arrayend
    {
        public void meth18()
        {
            int[] array = { 12, 0, 42, 0, 4 };
            int n = array.Length;
            int j = 0;
  
            for (int i = 0; i < n; i++)
            {
               if (array[i] != 0)
                {
                    int temp= array[j];
                    array[j] = array[i];
                    array[i] = temp;
                    j++;
                }

            }
            for (int i=0; i < n; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
   Console.ReadKey();
        }


    }
}
