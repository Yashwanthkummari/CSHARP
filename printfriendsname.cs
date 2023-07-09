using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    public class printfriendsname
    {
         public  void meth1()
        {
            string[] friendsname = { "yashwanth", "arun", "srikanth", "sai", "kyashwanth" };
            foreach (string s in friendsname) 
            {
            Console.WriteLine(s);
                Console.ReadLine();
            }
        }

    }
}

