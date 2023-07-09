using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    internal class Class8
    {
        public void meth7()
        {
            Console.WriteLine("enter the diameter");
            double diameter = Convert.ToDouble(Console.ReadLine());
            double perimeter =  2 * 3.14 * diameter / 2 ;
            double area = 2 * 3.14 * diameter * diameter / 4;
            Console.WriteLine("perimeter of a circle:" +  perimeter);
            Console.WriteLine("area of a circle:" +  area);
            Console.ReadLine(); 
            

        }
    }
}
