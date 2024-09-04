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
                case "sub":

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
            }
            return operation;
        } 
    }
}
