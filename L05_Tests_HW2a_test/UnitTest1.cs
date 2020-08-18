using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using L05_Tests_HW2a;

namespace L05_Tests_HW2a_test
{
    [TestClass]
    public class MathOperationsTest
    {
        [TestMethod]
        public void SumTest()
        {
            int a = 4;
            int b = 3;
            int expectedResult = 7;

            int actualResult = MathOperations.Sum(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SubtractTest()
        {
            int a = 4;
            int b = 3;
            int expectedResult = 1;

            int actualResult = MathOperations.Subtract(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            int a = 4;
            int b = 3;
            int expectedResult = 12;

            int actualResult = MathOperations.Multiply(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DivideTest()
        {
            int a = 10;
            int b = 2;
            int expectedResult = 5;

            int actualResult = MathOperations.Divide(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
