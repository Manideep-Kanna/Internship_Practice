using System;
using System.Collections;
namespace NonGeneric { 

    class NonGeneric
    {
        public static void Main(String[] args)
        {
            //ArrayList which is used to add any object into it same as list in python
            ArrayList ar = new ArrayList();
            ar.Add(1);
            ar.Add("Kanna");
            ar.Add(12.67);
            Console.WriteLine("ArrayList Adda");
            foreach (object o in ar)
            {
                Console.WriteLine(o);
            }
            //HashTable which is same as dictionary
            Hashtable ht = new Hashtable();
            ht.Add(1, "KANNA");
            ht.Add("manideep", "sitaraam");
            Console.WriteLine("HashTable Adda");
            foreach(DictionaryEntry dictionaryEntry in ht)
            {
                Console.WriteLine($"the key is {dictionaryEntry.Key} and the value is {dictionaryEntry.Value}");
            }
            //SortedList which is combination of HashTable and ArrayList it store as HashTable and sorts the values as per keys
            //Stack you know
            //Queue You Know
            //''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        }
    }

}
