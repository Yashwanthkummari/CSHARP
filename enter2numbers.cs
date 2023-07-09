using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
     class enter2numbers

    {
        public void meth3()
        {
            Console.WriteLine("enter first  number");
          double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter second number");
            double number2 = Convert.ToDouble(Console.ReadLine());
            double sum = number1 + number2;
            double difference = number1 - number2;  

            double squareofsum = Math.Pow(sum, 2);
            double squareofdifference = Math.Pow(difference, 2);
            Console.WriteLine("square of number:" + squareofsum);
            Console.WriteLine("square of number:" + squareofdifference);

            Console.ReadKey();
        }
        

    }
}
