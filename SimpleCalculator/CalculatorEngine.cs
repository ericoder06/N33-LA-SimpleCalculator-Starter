using System;
using CalcLibrary;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

            try
            {
                switch (argOperation.ToLower())
                {
                    case "+":
                    case "add":
                    case "plus":
                        result = CalcUtilities.add(argFirstNumber, argSecondNumber);

                        break;
                    case "-":
                    case "sub":
                    case "minus":

                        result = CalcUtilities.subtract(argFirstNumber, argSecondNumber);
                        break;

                    case "*":
                    case "multiply":
                    case "times":
                        result = CalcUtilities.multiply(argFirstNumber, argSecondNumber);
                        break;

                    case "/":
                    case "divide":
                    case "divided by":
                        result = CalcUtilities.divide(argFirstNumber, argSecondNumber);
                        break;



                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Specified operation is not recognized. Error", ex);
            }
            return result;
        }

        public string calculatorVocab(string argOperation)
        {
            string operation = "";
            
                switch (argOperation.ToLower())
                {

                    case "+":
                    case "add":
                        operation = "plus";
                        break;
                    case "-":
                    case "sub":
                        operation = "minus";
                        break;
                    case "*":
                    case "multiply":
                        operation = "times";
                        break;
                    case "/":
                    case "divide":
                        operation = "divided by";
                        break;

                default:
                    {
                        throw new ArgumentException("Invalid operation.");
                    }
             
            }
                return operation;
            } 
          
    }


}

