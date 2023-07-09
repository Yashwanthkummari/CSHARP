using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    class class5
    {
        public void meth4()
        {
            Console.WriteLine("enter a number");
            string number = Console.ReadLine();

            double numberstring = Convert.ToDouble(number);
            double result = numberstring * 10;
            string resultstring = result.ToString();
            Console.WriteLine("10 time of a number:" + resultstring);
            Console.ReadKey();
      
        }
    
        

    }
}
