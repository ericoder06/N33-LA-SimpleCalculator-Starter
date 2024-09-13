using System;
using CalcLibrary;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;
            bool validOperation = false;

            while (!validOperation)
            {
                try
                {
                    switch (argOperation.ToLower())
                    {
                        case "+":
                        case "add":
                        case "plus":
                            result = CalcUtilities.add(argFirstNumber, argSecondNumber);
                            validOperation = true;
                            break;
                        case "-":
                        case "sub":
                        case "minus":
                            result = CalcUtilities.subtract(argFirstNumber, argSecondNumber);
                            validOperation = true;
                            break;
                        case "*":
                        case "multiply":
                        case "times":
                            result = CalcUtilities.multiply(argFirstNumber, argSecondNumber);
                            validOperation = true;
                            break;
                        case "/":
                        case "divide":
                        case "divided by":

                            result = CalcUtilities.divide(argFirstNumber, argSecondNumber);
                            validOperation = true;
                            if (argSecondNumber == 0)
                            {
                                throw new DivideByZeroException("Cannot divide by zero");

                            }

                            break;
                        case "%":
                        case "mod":
                            result = argFirstNumber % argSecondNumber;
                            validOperation = true;
                            if (argSecondNumber == 0)
                            {
                                throw new DivideByZeroException("Cannot divide by zero");

                            }
                            break;
                        default:

                            Console.Write("Invalid operation. Please enter a valid operation (+, -, *, /, %) or (add, minus, multiply, divide, modulus):");
                            argOperation = Console.ReadLine();
                            validOperation = false;
                            break;
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);

                }
               
            }

            return result;
        }


        public string calculatorVocab(string argOperation)
        {
            string operation = "";
            
                switch (argOperation.ToLower())
                {

                   
                    case "add":
                        operation = "plus";
                        break;
                   
                    case "sub":
                        operation = "minus";
                        break;
                    
                    case "multiply":
                        operation = "times";
                        break;
                    
                    case "divide":
                        operation = "divided by";
                        break;
                    case "%":
                case "mod":
                    operation = "modulus";
                    break;

               
             
            }
                return operation;
            } 
          
    }


}

