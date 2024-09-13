using CalcLibrary;
using System;
using System.Reflection.Emit;


namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Class to convert user input
                InputConverter inputConverter = new InputConverter();

                // Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();
                Console.WriteLine("Welcome to MyCalculator! \n");
                Console.WriteLine("Please enter your equation in this order: \n " +
                "1. First Number \n 2. Second Number \n 3. Operation");
                Console.WriteLine("\nPress Enter to start.");
                Console.ReadLine(); 
             
              
         
                // Calculation
                double firstNumber = inputConverter.ConvertInputToNumeric( "Please enter your first Number: ");
                double secondNumber = inputConverter.ConvertInputToNumeric(  "Please enter your second Number: ");
                Console.Write("Please enter the operation you would like to perform: ");
                string operation = Console.ReadLine();

                // Perform the calculation
                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                // Output the result

                if((operation.ToLower().Equals("divide") || operation.Equals("/") && secondNumber == 0))
                {
                    Console.WriteLine("Cannot divide by zero");
                }
                else if (operation.ToLower().Equals("mod") || operation.Equals("%") && secondNumber == 0)
                {
                    Console.WriteLine("Cannot mod by zero");
                }
                else
                    Console.WriteLine(String.Format("The value {0:0.00##} {1} the value of {2:0.00##} is equal to {3:0.00##}", firstNumber, calculatorEngine.calculatorVocab(operation.ToLower()), secondNumber, result));

            } catch (Exception ex)
            {
               
                Console.WriteLine(ex.Message);
            }

        }
       

    }
}
