using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public double Marks { get; set; }



    }
}