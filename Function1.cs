using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    internal class Function1
    {
        public void array2d()
        {
            Console.WriteLine(" number of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("number of columns");
            int cols = Convert.ToInt32(Console.ReadLine());


            int[,] intarray = new int[rows , cols ];
            double[,] doublearray = new double[rows , cols ];
            bool[,] boolarray = new bool[rows , cols ];

            Console.WriteLine(" enter tne value of integer array");
            for(int i = 0; i < rows ; i++)
            {
                for(int j = 0; j < cols ; j++)
                {
                    intarray[i,j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            Console.WriteLine(" enter the value of double array");
            for(int i=0; i < cols ; i++)
            {
                for( int j = 0; j < rows; j++)
                {
                    doublearray [i,j] = Convert.ToDouble(Console.ReadLine());


                }
            }

            Console.WriteLine("enter the value for boolean array");
            for(int i= 0; i < rows ; i++)
            {
                for (int j = 0;j < cols ; j++)
                {
                    boolarray[i,j]= Convert.ToBoolean(Console.ReadLine());  
                }
            }












        }
    }
}
