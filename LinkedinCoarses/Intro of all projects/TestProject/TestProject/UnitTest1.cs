using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using salcal;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {
            //Arrange
            SalaryCalculator sc = new SalaryCalculator();
            //Act
            decimal annualSalary = sc.GetAnnualSalary(50);
            //Assert
            Assert.AreEqual(104000, annualSalary);
        }
    }
}
