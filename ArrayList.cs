
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{    
        class Program
        {
            static void main(string[] args)
            {
                ArrayList al = new ArrayList();

                al.Add(100); 
                al.Add("yashwanth"); 
                al.Add("Manager"); 
                al.Add(3500); 
                al.Add("Hyderabad"); 
                al.Add("IT"); 
                al.Add("yashwanth.k.com");

            Console.WriteLine("printing the values using for each loop");
            foreach(var obj in al) 
            {
                Console.WriteLine(obj + "");
            }
                Console.WriteLine( al[4]);

              
                Console.WriteLine("Emaild ID : " + al[6]);

                Console.ReadKey();
            }
        }
    }



