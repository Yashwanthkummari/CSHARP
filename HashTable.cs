using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    internal class HashTable
    

        {
            static void main()
            {

            Hashtable hashtable = new Hashtable();

                hashtable.Add("EId", 1001); //hashtable.Add(object key,object value)
                hashtable.Add("Name", "James"); 
                hashtable.Add("Salary", 3500); 
               hashtable.Add("Location", "Mumbai");
                hashtable.Add("EmailID", "a@a.com"); 

                
                Console.WriteLine("Printing Hashtable using Foreach Loop");
                foreach (object key in hashtable.Keys)
                {
                    Console.WriteLine(key + " : " + hashtable[key]);//key : value
                }
                //Or
                //foreach (DictionaryEntry de in hashtable)
                //{
                //    Console.WriteLine($"Key: {de.Key}, Value: {de.Value}");
                //}

                Console.WriteLine("\nPrinting Hashtable using Keys");
                Console.WriteLine("Location : " + hashtable["Location"]);  //printing using key value location
                Console.WriteLine("Emaild ID : " + hashtable["EmailID"]); // printing using key value e.mail
                Console.WriteLine(hashtable["Salary"]); // printing using key value 

              Console.ReadKey();
            }
        }
    }

