using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddCalculator.Library;

namespace TddCalculator.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void ShouldReturnPositveNumberOnPassingTwoPositiveNumber()
        {
            Calculator CalObj = new Calculator();
            int num1 = 5;
            int num2 = 7;
            int resultSum = CalObj.Addition(num1, num2);
            Assert.AreEqual(12, resultSum, "Testing result for addition of 5 and 7");
        }
    }
}
