using PRACTICEPROBLEMSDAY1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    public interface IAbstractionInterface

    {
        void withdrawmoney();
        void checkbalance();
        void validatecard();
    }
}


    public class Sbi : IAbstractionInterface
     {
        
         public void withdrawmoney()
         {
             Console.WriteLine(" SBI Bank withdraw money");
         }
    public void checkbalance()
    {
        Console.WriteLine(" SBI bank cheeck balance ");

    }
    public void validatecard() 
    {
        Console.WriteLine(" sbi validate card");
    }
     }
 

     


    


