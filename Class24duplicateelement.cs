using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    internal class Class24duplicateelement
    {
        public void duplicateelement()
        {
            object[] originalarray = { "25", "anna", "false", "25", "4/15/2021 12:10:51 pm ", "112.22", "anna", "false" };
            Console.WriteLine("\noriginalarray");
            for(int i = 0; i < originalarray.Length; i++)
            {
                Console.WriteLine(originalarray[i]);

            }
            object[] newarray = originalarray.Distinct().ToArray();
            Console.WriteLine("\nnew array:");
            for(int i = 0;i < newarray.Length; i++)
            {
                Console.WriteLine(newarray[i]);
            }
            Console.ReadLine();
            
        }
    }
}
