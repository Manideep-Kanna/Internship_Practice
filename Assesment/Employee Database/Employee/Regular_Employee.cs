
namespace Assesment
{
    internal class Regular_Employee:Employee
    {
        // calling Employee class constructor from the Contract_Employee constructor
        public Regular_Employee(int emp_id,string emp_name,int dept_id,int emp_sal, string emp_add, DateTime date,int bonus)
            : base(emp_id, emp_name, dept_id, emp_sal, emp_add, date, bonus)
        {
            
        }
        //Calculating Regular Employee salary
        public override double GetEmployeeSalaryInfo(int emp_id)
        {
            double salary = Salary+Bonus;
            return salary;
        }


    }
}
