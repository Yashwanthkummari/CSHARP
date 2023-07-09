using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    class queue
        { 
        static void main(string[] args)
            {
                Queue queue = new Queue();
                queue.Enqueue(1000);
                queue.Enqueue("yashwanth");
                queue.Enqueue(21.4f);
                queue.Enqueue(true);
                queue.Enqueue(86.8);
                queue.Enqueue('y');
               foreach (var item in queue)
                {
                    Console.WriteLine(item);
                }
                   Console.ReadLine();
                   Console.WriteLine("Total number of elements in a queue are " + queue.Count);
            queue.Dequeue();
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine() ;
            Console.WriteLine("Total number of elements in a queue are " + queue.Count) ;
            Console.WriteLine(queue.Peek());
            Console.ReadLine() ;
        }
        }
    }


