using System;

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
                    result = argFirstNumber + argSecondNumber;

                    break;
                case "-":
                case "substract":
                    
                        result = argFirstNumber - argSecondNumber;
                    break;

                case "*":
                case "multiply":
                    result = argFirstNumber * argSecondNumber;
                    break;

                case "/":
                case "divide":
                result = argFirstNumber / argSecondNumber;
                    break;



            }
            return result;
        }
    }
}
