using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    public class MethodOverriding
    {
        public void program()
        {
            Console.WriteLine("  parent program method is called  ");
            Console.ReadLine();  
        } 
        public  virtual void   test() // once we use a virtual modifier this method is overrideble 
        {
            Console.WriteLine("parent test method is called");
            Console.ReadLine(); 
        }
    }
   
}
