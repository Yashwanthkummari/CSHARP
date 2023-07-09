using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    internal class Class10
    {
        public void meth9()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long sum =0;
            for (int i = 0; i < 1000000; i++)
            {
                sum = +i;
                
            }
            stopwatch.Stop();

            TimeSpan elapsedtime = stopwatch.Elapsed;
            double executiontimesec = elapsedtime.TotalSeconds;
            double executiontimems = elapsedtime.TotalMilliseconds;

            Console.WriteLine("executiontime:" + executiontimesec + "sec");
            Console.WriteLine("execution time:" + executiontimems + "ms");
            Console.ReadKey();

        }
    }
}
