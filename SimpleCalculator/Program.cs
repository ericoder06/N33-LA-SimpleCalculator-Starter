using CalcLibrary;
using System;

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
                Console.Write("Please enter your first Number: ");
                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.Write("Please enter your second Number: ");
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.Write("Please enter the Operation needed: ");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                
                Console.WriteLine(String.Format("The value {0:0.00##} {1} the value of {2:0.00##} is equal to {3:0.00##}", firstNumber, calculatorEngine.calculatorVocab(operation.ToLower()), secondNumber, result));

            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }

        }
    }
}
