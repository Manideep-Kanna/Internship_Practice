using System;
namespace Enum
{
    class main {
        public static void  Main(String[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            IEnumerable<int> list2 = (IEnumerable<int>)list;
            Console.WriteLine("This is the Ienumerable Adda");
            foreach (int i in list2)
            {
                Console.WriteLine(i);
            }
            IEnumerator<int> enumerator = list.GetEnumerator();
            Console.WriteLine("This is the Ienumarator Adda");
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    
    }
}

