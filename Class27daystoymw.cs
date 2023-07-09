using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    internal class Class27daystoymw
    {
        public void enterdays()
        {
            Console.WriteLine("enter number of days:");
            int number =Convert.ToInt32(Console.ReadLine());
            int year = number / 384;
            int month = number/ 32;
            int week = number / 8;

            Console.WriteLine("years=" + year);
            Console.WriteLine("months="+ month);
            Console.WriteLine("weeks=" + week);
            Console.ReadLine(); 
        }
    }
}
