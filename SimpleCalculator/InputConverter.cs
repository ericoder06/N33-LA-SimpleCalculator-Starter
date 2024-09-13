using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {


            if (double.TryParse(argTextInput, out double numericValue))
            {
                return numericValue;
            }
            else
            {

                throw new ArgumentException("Input is not a valid number.");
            }
        }
    }
}

