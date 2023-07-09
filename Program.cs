using PRACTICEPROBLEMSDAY1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    public class Program
    {
        public static void Main(string[] args)

        {
            Console.WriteLine("enter your problrm number");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    new printfriendsname().meth1();
                    break;
               
                case 2:
                    new enter2numbers().meth3();
                    break;
                case 3:
                    new placename().meth2();
                    break;
                case 4:
                    new class5().meth4();
                    break;
                case 5:
                    new Class6().meth5();
                    break;
                case 6:
                    new Class7().meth6();
                    break;
                case 7:
                    new Class8().meth7();
                    break;
                case 8:

                    new Class9().meth8();   
                    break;
                case 9:
                    new Class10().meth9();
                    break;
                case 10:
                    new Class11().meth10();
                    break;
                case 11:
                    new Class12().meth11();
                    break;
                case 12:
                    new Class13().meth12();
                    break;
                case 13:
                    new Class14().meth13();
                    break;
                case 14:
                    new Class15().meth14();
                    break;
                case 15:
                    new Class16presentabsent().meth15();
                    break;
                case 16:
                    new Class17arrayaverage().meth16();
                    break;
                case 17:
                    new Class18arrayprimenumbers().meth17();
                    break;
                case 18:
                    new Class19shift0arrayend().meth18();
                    break;
                case 19:
                    new Class20firstrepeatedelement().meth19();
                    break;
                case 20:
                    new Class21arthemeticexpression().meth20();
                    break;
                case 21:
                    new Class22deleteposition().meth21();
                    break;
                case 22:
                    new Class23secondlargestnumber().largestnumber();
                    break;
                case 23:
                    new Class24duplicateelement().duplicateelement();
                    break;
                case 25:
                    new Class26smallestgap().smallestgap();
                    break;
                case 26:
                    new Class27daystoymw().enterdays();
                    break;
                case 27:
                    new Class28sqrtnumber().sqrtnumber();
                    break;
                case 28:
                    new Class29primenmbrs1to100().primenumber();
                    break;
                case 29:
                    new BubbleSort();
                    break;
                case 30:
                    new Inheritence();
                    break;
                case 31:
                    inheritance2 i = new inheritance2();
                    i.vehicle();
                    i.childVehicle();
                    break;
                case 32:
                    inheritance3 k = new inheritance3();
                    k.vehicle();
                    k.childVehicle();
                    k.Grandchildvehicle();
                    break;
                case 33:
                    PolymerphismMOL polymerphismMOL = new PolymerphismMOL();
                    polymerphismMOL.Test();
                    polymerphismMOL.Test( 100 );
                    polymerphismMOL.Test("yashwanth");
                    polymerphismMOL.Test("yashwanth" , 1000);
                    polymerphismMOL.Test(100 , " yashwanth ");
                    break;
                case 34:
                    MethodOverriding2 methodOverriding2 = new MethodOverriding2();
                    methodOverriding2.program();
                    methodOverriding2.program(100);
                    methodOverriding2.test();
                    break;
                case 35:
                    Bank bank = new Bank();
                    bank.SetBalance(201);
                    bank.SetName("yashwanth");
                    Console.WriteLine(bank.GetBalance());
                    Console.WriteLine(bank.GetName());
                    Console.ReadKey();
                    break;
                case 37:
                    ImplementationClass1 implementationClass1 = new ImplementationClass1();
                    implementationClass1.add(100 , 200);
                    ImplementationClass2 implementationClass2 = new ImplementationClass2();
                    implementationClass2.add(200, 300);
                    implementationClass2.sub(200, 100);
                    break;
                case 38:
                   IAbstractionInterface a = new Sbi();
                    a.withdrawmoney();
                    a.checkbalance();
                    a.validatecard();
                    
                    break;
                case 39:
                    Abstractionclass l =new ChildAbstract();
                    l.place();
                    break;
             
            }
        }

    }
}
