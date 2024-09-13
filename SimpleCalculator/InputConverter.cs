using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {
            if(!double.TryParse(argTextInput, out double convertedNumber))
            {
                throw new ArgumentException("Expected a numeric value. Error");
            }

            double numericValue;
            bool parsing = double.TryParse(argTextInput, out numericValue);

            return numericValue;
        }
    }
}
