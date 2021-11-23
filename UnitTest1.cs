using Microsoft.VisualStudio.TestTools.UnitTesting;
using P6;
using System;

namespace MedianUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindMedianTest1()
        {
            //Arrange 
            double expectedMedian = 25;
            double actualMedian;
            double num1 = 12;
            double num2 = 25;
            double num3 = 63;

            //Act 
            Median m = new Median(num1, num2, num3);
            actualMedian = m.FindMedian(num1, num2, num3);

            //Assert
            Assert.IsTrue((actualMedian == expectedMedian), "Median calculated incorrectly");
        }
        [TestMethod]
        public void FindMedianTest2()
        {
            //Arrange 
            double expectedMedian = 66;
            double actualMedian;
            double num1 = 66;
            double num2 = 5;
            double num3 = 72;

            //Act 
            Median m = new Median(num1, num2, num3);
            actualMedian = m.FindMedian(num1, num2, num3);

            //Assert
            Assert.IsTrue((actualMedian == expectedMedian), "Median calculated incorrectly");
        }

    }
}
