using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    public class placename
    {
       public void meth2()
            
        {
            Console.WriteLine("Enter the place name you like to visit");
            string placename = Console.ReadLine();
            Console.WriteLine("placename in uppercase:" + placename.ToUpper());
            Console.WriteLine("placename in lowercase:" + placename.ToLower());
            Console.ReadKey();
        }  


    }
}
