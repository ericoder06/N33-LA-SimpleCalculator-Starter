using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("add", number1, number2);
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("+", number1, number2);
            Assert.AreEqual(3, result);

        }
        [TestMethod]
        public void SubtractsTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("sub", number1, number2);
            Assert.AreEqual(-1, result);

        }
        [TestMethod]
        public void substractTwoNumbersUsingTheDashInsteadOfWording()
        {

            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("-", number1, number2);
            Assert.AreEqual(-1, result);

        }
        [TestMethod]
        public void multiplyTwoNumbers()
        {

            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("multiply", number1, number2);
            Assert.AreEqual(2, result);

        }
        [TestMethod]
        public void multiplyTwoNumbersUsingAsterix()
        {

            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("*", number1, number2);
            Assert.AreEqual(2, result);

        }
        [TestMethod]
        public void divideTwoNumbers()
        {

            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("divide", number1, number2);
            Assert.AreEqual(0.5, result);

        }
        [TestMethod]
        public void divideTwoNumbersUsingSlash()
        {

            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("/", number1, number2);
            Assert.AreEqual(0.5, result);

        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void invalidOperationTest()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("invalid", number1, number2);
            Assert.AreEqual(0.5, result);

        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void divideByZeroTest()
        {
            int number1 = 1;
            int number2 = 0;
            double result = _calculatorEngine.Calculate("/", number1, number2);
            Assert.AreEqual(0.5, result);

        }
    }
}
