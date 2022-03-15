
namespace Assesment
{
    public class Emp_Details { 
    public static void Main(String[] args)
        {
            //Creating Regular Employee and Contract Employee Objects
            Regular_Employee reg_emp = new Regular_Employee(1, "kanna",19, 50000, "Tummapalli Street ", new DateTime(2018,03,23), 600);
            Contract_Employee con_emp = new Contract_Employee(2, "manideep", 20, 52347, "Radhe Shyam Street ", new DateTime(2020, 01, 22));
            //Getting the Regular Employee Details
            Console.WriteLine("Regular Employee Details");
            reg_emp.GetEmployeeDetails(1);
           Console.WriteLine("The total salary of the employee is "+reg_emp.GetEmployeeSalaryInfo(1));
            //Getting the Contract Employee Details
            Console.WriteLine("Contract Employee Details");
            con_emp.GetEmployeeDetails(2);
            Console.WriteLine("The total salary of the is "+con_emp.GetEmployeeSalaryInfo(2));

        }
    
    }
}