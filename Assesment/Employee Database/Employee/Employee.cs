using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal class Employee
    {
        public int EmployeeId;
        public string Name;
        public int DepartmentId;
        public DateTime joining_date;
        public string address;
        public double Salary;
        public double Bonus;
      public  Employee(int emp_id,string emp_name,int dept_id,int emp_sal,string emp_add,DateTime date,int bonus)
        {
            EmployeeId = emp_id;
            Name = emp_name;
            DepartmentId = dept_id;
            Bonus = bonus;
            Salary = emp_sal;
            joining_date = date.Date;
            address = emp_add;
        }
        //Displaying the employee Details
      public  void GetEmployeeDetails(int emp_id)
        {
            //Changing Datetime only Date
            string joining_onlydate=joining_date.ToString("d/M/yyyy");
            Console.WriteLine("THE DETAILS OF THE EMPLOYEE");
            Console.WriteLine($"The name of the employee is :{Name}");
            Console.WriteLine($"The Department ID of the employee is :{DepartmentId}");
            Console.WriteLine($"The joining_date of the employee is :{joining_onlydate}");
            Console.WriteLine($"The address of the employee is :{address}");
            Console.WriteLine($"The Base Salary of the employee is :{Salary}");
            Console.WriteLine($"The Bonus of the employee is :{Bonus}");
        }
        //Made an virtual function so that derived classes can override it
     public virtual double GetEmployeeSalaryInfo(int emp_id)
        {
            return 0;
        }


    }
}
