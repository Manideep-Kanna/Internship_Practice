
namespace Assesment
{
    internal class Contract_Employee:Employee
    {
        //Calling Employee Constructor from the Contract_Employee Constructor
        //As contract employee have no bonus we have send 0 in the bonus parameter
        public Contract_Employee(int emp_id, string emp_name, int dept_id, int emp_sal, string emp_add, DateTime date)
            : base(emp_id, emp_name, dept_id, emp_sal, emp_add, date,0)
        {

        }
        //Contract employee get 3% of salary as sales incentive
        public override double GetEmployeeSalaryInfo(int emp_id)
        {
            double salary = Salary + 0.03*Salary ;
            return salary;
        }
    }
}
