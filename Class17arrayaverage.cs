using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    internal class Class17arrayaverage
    {
        public void meth16()
        {
            
            float[] numbers  = { 5.5f , 6.7f , 7.8f, 3.5f , 6.5f };
            
            int count =numbers.Length;
            float sum = 0;

            for (int i = 0; i <numbers.Length; i++)
            {
                sum += numbers[i];
               
            }
            float average = sum / count;
            Console.WriteLine(average); 
           
            Console.ReadKey();
        }
    }

    }

