using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Threads
{
    /// <summary>
    /// This class generates and iterates through the perfect square lilst
    /// </summary>
    internal class SomeOtherClass
    {
        List<int>list=new List<int>();
        //Iterates through the perfect square list
      public  void IterateThroughList()
        {
            for(int i = 0; i < 28; i++)
            {
                if (i >= list.Count)
                {
                    //when the i value increased list count it gives us the exeception
                    throw new ArgumentOutOfRangeException("In List we contain upto 20 perfect squares only");
                }
                Console.WriteLine($"The perfect square of {i+1} is {list[i]}");
 
            }
        }
        //Generate the perfect square list
      public  void GenerateListOfPerfectSquareNumbers()
        {
            //Generates the list of 1 to 20 numbers of perfect squares
            for(int i=1; i<=20; i++)
            {
                list.Add(i*i);
            }
        }
    }
}
