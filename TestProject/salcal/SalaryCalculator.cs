using System;

namespace salcal
{
    public class SalaryCalculator
    {
        public decimal GetAnnualSalary(decimal houlyWage)
        {
            const int HoursInYear = 2080;
            decimal annualSalary = houlyWage * HoursInYear;
            return annualSalary;
        }
    }
}
