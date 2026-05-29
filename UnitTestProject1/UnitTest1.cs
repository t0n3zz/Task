using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void firstTest()
        {
            double result = Task.Service.Calculator.CalculateTips(3000.00, 3200.00);

            Assert.AreEqual(200.00, result);
        }

        [TestMethod]
        public void secondTest()
        {
            double result = Task.Service.Calculator.CalculateTips(3000.00, 3200.00);

            Assert.AreNotEqual(0.0, result);
        }

        [TestMethod]
        public void thirdTest()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                Task.Service.Calculator.CalculateTotalWithTips(0, 0)
            );
        }

        [TestMethod]
        public void fourthTest()
        {
            bool result = Task.Service.Calculator.CanContinue(-1);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void fifthTest()
        {
            bool result = Task.Service.Calculator.CanContinue(1);
            Assert.IsTrue(result);
        }
    }
}
