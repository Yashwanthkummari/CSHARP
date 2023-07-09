using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    internal class Dictionary
    
        {
            static void Main()
            {
                Dictionary<string, object> dictionarynames = new Dictionary<string, object>();

                dictionarynames.Add("yashwanth number", 9866952244 );
                dictionarynames.Add("srikanth designation&location", " software warangal");
                dictionarynames.Add("nikihl initial", 't');
            dictionarynames.Add("sai grade", 9.65);

            Console.WriteLine("Accessing Dictionary Elements using For Each Loop");
                foreach (KeyValuePair<string, object> KVP in dictionarynames)
                {
                    Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}");
                }

                Console.WriteLine("\nAccessing Dictionary Elements using Keys");
                Console.WriteLine($"Key: yashwanth number, Value: {dictionarynames["yashwanth number"]}");
                Console.WriteLine(dictionarynames["srikanth designation&location"]);
                Console.WriteLine($"Key: nikihl initial, Value: {dictionarynames["nikihl initial"]}");
                 Console.WriteLine($"Key: sai grade, Value: {dictionarynames["sai grade"]}");


            Console.ReadKey();
            }
        }
    }
