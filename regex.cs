using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace project
{
    internal class regex
     {
        static void main(string[] args)
        {
            string[] inputname = { "yashwanth", "Yashth", "YahWtH", "K.Yashwanth", "k.Yaaashhhwaaanasgbnhb" };
            string[] inputnumber = {"9123982301","123456789", "9845721598","321-1234-5678", "09876543210"};
            string[] inputemail = { "yashwant.k1119@gmail.com", "Yashwwan123jmahsd22@gmail.com",
                             "3@gmail.com"," aaabbbwwwhh33355443644535sssnasdfgfsdf@gmail.com,K.yashwanth@yahoo.com"};
           foreach (string nu in inputnumber)
            {
                Console.WriteLine("{0} {1} a valid mobile number.", nu,
                            isValidMobileNumber(nu) ? "is" : "is not");
            }

            Console.ReadKey();
            foreach(string na in inputname)
            {
                Console.WriteLine(" {0} a Valid name ",na, isvalidname(na) ? "is" : "is not");
            }
            Console.ReadKey();
            foreach (string e in inputemail)
            {
                Console.WriteLine(" {0} a Valid email ",e, isvalidemail(e) ? "is" : "is not");

            }
            Console.ReadKey();
        }   
        public static bool isValidMobileNumber(string inputMobileNumber)
        {
          string iPnumberRegex = @"^[6-9]{1}[0-9]{9}$";

              Regex numberregex = new Regex(iPnumberRegex);

            if (numberregex.IsMatch(inputMobileNumber))
                return (true);
            else
                return (false);
        }
        public static bool isvalidname(string inputname)
        {
            string iPnameregex = @"(^[a-z]{}$)|(^[a-zA-z]$)| (^[A-Za-z]{1}.[a-zA-Z]{1}[a-z]{8}$)
                                  (^\s$)";
            Regex nameregex = new Regex(iPnameregex);
          if (nameregex.IsMatch(inputname)) 
                
                return (true);
            else

                return (false);
        }
        public static bool isvalidemail(string inputemail)
        {
            string iPemailregex = @"(([a-z){1,20}.[a-z]{1}@[a-z]{5}.(com|in|jhgv))|([a-z]@[a-z].[a-z]{3})|
                                    \s[a-zA-Z0-9]?@[a-z].(com|yahoo|.in))";
           
            Regex emailregex = new Regex(iPemailregex);

            if (emailregex.IsMatch(inputemail))

                return (true);
            else
                return (false);
        }
        }
    }



