using System;
using static System.Net.Mime.MediaTypeNames;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string text)
        {
            double numericValue;
            while (true)
            {
                Console.Write(text);
                string argTextInput = Console.ReadLine(); 
                if (double.TryParse(argTextInput, out numericValue))
                {
                    return numericValue;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");

                }
            }
        }
    }
}

