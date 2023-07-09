using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    internal class BubbleSort
    {
        public BubbleSort() 
        {
            Console.WriteLine("enter size of array");
            int Size = int.Parse(Console.ReadLine()); 
            int[ ] array = new int[Size];
            Console.WriteLine("enter" + Size + " elements");
            for (int i = 0; i < Size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Before sort");
            for(int i = 0; i < Size; i++)
            {
                Console.Write(array[i]+",");    
            }
            for(int i = 0; i < Size;i++)
            {
                for(int j = 0; j < Size; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("/nafter bubble sort");
            for(int i = 0; i < Size;i++)
            {
                Console.Write(array[i] + "");
               
            }
            Console.ReadKey();  
        } 
    }
}
