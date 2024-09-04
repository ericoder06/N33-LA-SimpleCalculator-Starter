using System;
using CalcLibrary;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;


            switch (argOperation.ToLower())
            {
                case "+":
                case "add":
                   result = CalcUtilities.add(argFirstNumber, argSecondNumber);

                    break;
                case "-":
                case "substract":
                    
                        result = CalcUtilities.subtract(argFirstNumber, argSecondNumber);
                    break;

                case "*":
                case "multiply":
                    result = CalcUtilities.multiply(argFirstNumber, argSecondNumber);
                    break;

                case "/":
                case "divide":
                  result = CalcUtilities.divide(argFirstNumber, argSecondNumber);
                    break;



            }
            return result;
        }
    }
}
