using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    internal class MethodOverriding2 : MethodOverriding
    {
        public void program( int i )
        {
            Console.WriteLine("  parent program method is called  ");
            Console.ReadLine();
        }
        public override  void test()
        {
            Console.WriteLine("childs test method is called");
            Console.ReadLine();
        }
    }

    }

