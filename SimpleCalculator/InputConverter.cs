using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {
         double numericValue;
         bool parsing = double.TryParse(argTextInput, out numericValue);

            return numericValue;
        }
    }
}
