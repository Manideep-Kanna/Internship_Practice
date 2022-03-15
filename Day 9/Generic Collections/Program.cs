using System;
using System.Collections;

namespace GenericCollections
{
    namespace GenericCollections
    {
        public class main
        {
            public static void Main(String[] args)
            {
                //List
                List<int> list = new List<int>();
                list.Add(1);
                list.Add(2);
                list.Add(3);
                printList(list);
                //Dictionary
                Dictionary<int,string>dict=new Dictionary<int,string>();
                dict.Add(1, "kanna");
                dict.Add(3, "sita");
                dict.Add(2, "manideep");
                printDict(dict);
                //SortedList
                SortedList<int, string> sl = new SortedList<int, string>();
                sl.Add(3, "sita");
                sl.Add(1, "kanna");
                sl.Add(2, "manideep");
                printSortedList(sl);
                //There are other DS we can leave them for now


            }

            static void printList(List<int> list)
            {
                Console.WriteLine("This is List Adda");
                foreach(int item in list)
                {
                    Console.WriteLine(item);
                }
            }
            static void printDict(Dictionary<int, string> dict)
            {
                Console.WriteLine("This is the dictionary Adda");
                foreach(KeyValuePair<int,string> kvp in dict)
                {
                    Console.WriteLine($"The key is {kvp.Key} and the value is {kvp.Value}");
                }
            }
            static void printSortedList(SortedList<int, string> dict)
            {
                Console.WriteLine("This is the SortedList Adda");
                foreach (KeyValuePair<int, string> kvp in dict)
                {
                    Console.WriteLine($"The key is {kvp.Key} and the value is {kvp.Value}");
                }
            }
        }
    }
}