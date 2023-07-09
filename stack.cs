using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    internal class program
    {
        static void main(string[] args)
        {

            Stack mystack = new Stack();

            mystack.Push(1000000);
            mystack.Push("yashwanthhhhh");
            mystack.Push(71.4f);
            mystack.Push(true);
            mystack.Push(96.8);
            mystack.Push('k');


            foreach (var item in mystack)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            Console.WriteLine("Total number of elements in a stack are " + mystack.Count);
               mystack.Pop();
            foreach (var item in mystack)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.WriteLine("Total number of elements in a stack are " + mystack.Count);
            Console.WriteLine(mystack.Peek());
            Console.ReadLine();
        }
    }
}

