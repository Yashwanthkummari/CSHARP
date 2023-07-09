using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    public class Class13
    {
        int n = 1;

        public void meth12()
        {
            if (n <= 100)
            {
              

                Console.Write(n + "");
                n++;
                this.meth12();
                Console.ReadLine();
            }

        }
    }
}
