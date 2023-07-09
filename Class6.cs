using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    class Class6
    {
        public void meth5()
  
                {
                    Console.WriteLine(" enter full name ");
                  
                string fullname = Console.ReadLine();
                string[] nameparts = fullname.Split(' ');

                Console.WriteLine("number of parts in a name:" + nameparts.Length);
                Console.WriteLine(" different parts of name: ");
                foreach (string name in nameparts)
                {
                    Console.WriteLine(name);
                }
                string a3 = string.Join("",nameparts);
                Console.WriteLine(a3);

                    Console.ReadKey();
                }

            }
        }
    
