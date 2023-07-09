using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    public interface ItestInterface1
    {
        void add(int num1, int num2 );
       

    }

   public  interface Itestinterface2 : ItestInterface1
    {
        void sub(int num1 , int num2 );
    }

    public class ImplementationClass1 : ItestInterface1
    {


        public void add(int num1, int num2)
        {
            Console.WriteLine($" sum of {num1} and{ num2}  is  { num1 + num2}");
            Console.ReadLine();
        }
    }
    public class  ImplementationClass2 : Itestinterface2
    {
        public void add(int num1, int num2)
        {
            Console.WriteLine($"sum of {num1} and {num2} is {num1+num2} ");
            Console.ReadLine();
        }
        public void sub(int num1, int num2)
        {
            Console.WriteLine($"diff of {num1} and {num2} is {num1 - num2}");
            Console.ReadLine();
        }

        
    }
    
       
}
