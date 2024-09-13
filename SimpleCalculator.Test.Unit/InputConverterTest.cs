using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertsValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertsInvalidStringInputIntoDouble()
        {
            string inputNumber = "*";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(2, convertedNumber);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertsInvalidStringInputIntoDouble2()
        {
            string inputNumber = "a";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(2, convertedNumber);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void failureToConvertExclamationPointtoDouble()
        {
            string inputNumber = "!";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(2, convertedNumber);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailuretoConvertEmptyStringToDouble()
        {
            string inputNumber = " ";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(2, convertedNumber);
        }
        [TestMethod]
        public void ConvertsZeroStringtoDouble()
        {
            string inputNumber = "0";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
       
            Assert.AreEqual(0, convertedNumber);
        }
    }
}
