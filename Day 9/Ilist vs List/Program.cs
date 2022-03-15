using System;
using System.Collections;
/*Why we should use interface it is not safe to expose the classes if i expose class then any client can add 
 new funcitonality to it so i dont want that to happen i will only give access to the interface by which they cant 
add any new functionality they can just access and use the funcitons*/
namespace ilist
{
    public class Difference
    {
        public static void Main(String[] args)
        {
            //IF i use ilist i cant use the print(list type ) method

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Print(list);
            IPrint(list);

        }
        public static void Print(List<int> list)
        {
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void IPrint(IList<int> list)
        {
            foreach (int item in list)
            {

                Console.WriteLine("The ilist interface element {0}", item);
            }

        }

    }
}
