using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    internal class Class9
    {
        public void meth8()
        {
            Console.Write("enter the year");
            int year = int.Parse(Console.ReadLine());
            Console.Write("enter the month number [1-12]");
            int month = int.Parse(Console.ReadLine());
            Console.Write("enter the date [1-31]");
            int date = int.Parse(Console.ReadLine());

            DateTime inputdate = new DateTime(year, month, date);
            DateTime nextdate = inputdate.AddDays(1);

            Console.WriteLine("the next date is [yyyy-mm-dd]:" + nextdate.ToString("yyyy-mm-dd"));
            Console.ReadKey();
        }


    }
}
