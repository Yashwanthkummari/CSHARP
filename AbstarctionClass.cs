using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    public abstract class Abstractionclass
        {
        public abstract void place();
    }
    public class ChildAbstract : Abstractionclass
    {
        override
            public void place()
        {
            Console.WriteLine("abstract class overriding");
            Console.ReadLine(); 
        }
    }

    
    }

