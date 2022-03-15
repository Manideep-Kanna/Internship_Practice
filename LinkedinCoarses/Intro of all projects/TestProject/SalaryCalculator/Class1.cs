namespace SalaryCalculator
{
    public class SalaryCalculator
    {
        public decimal GetAnnualSalary(decimal houlyWage)
        {
            const int HoursInYear = 2080;
            decimal annualSalary = houlyWage * HoursInYear;
            return 0;//annualSalary
        }

    }
}