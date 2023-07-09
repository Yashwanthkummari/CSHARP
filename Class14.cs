using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    internal class Class14
    {
        public void meth13()
        {
            Console.WriteLine("enter a value ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter b value");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter c value ");
            double c = Convert.ToDouble(Console.ReadLine());
            double d = b * b - 4.0 * a * c;
          
            if (d> 0)
            {
                double r1 = (-b + Math.Sqrt(d)) / (2.0 * a);
                double r2 = (-b - Math.Sqrt(d)) / (2.0 * a);
                Console.WriteLine("the roots are:" + r1 +"," + r2);

            }
            else if (d == 0)
            {
                double r1 = -b / (2.0 * a);
                Console.WriteLine("the root is:" + r1);

            }
            else
            {
                Console.WriteLine("Roots are n0t real");
            }
            Console.ReadKey();
        }
    }
}
